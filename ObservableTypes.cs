using System.ComponentModel;

namespace QtSampleApp;

public sealed class Exposer
{
	public Exposer()
	{
		Observable = new Observable();
		ObservableViaInterface = Observable;

		Observable.PropertyChanged += ObservableOnPropertyChanged;

		_ = MyIntUpdateLoop();
	}

	public Observable Observable { get; }

	public IObservable ObservableViaInterface { get; }

	private async Task MyIntUpdateLoop()
	{
		while (true)
		{
			await Task.Delay(1000);
			Observable.MyInt++;
			Console.WriteLine($"Property {nameof(Observable.MyInt)} updated to {Observable.MyInt}.");
		}
	}

	private void ObservableOnPropertyChanged(object? sender, PropertyChangedEventArgs e)
	{
		Console.WriteLine($"Detected property {nameof(Observable.MyInt)} update to {Observable.MyInt}.");
	}
}

public interface IObservable : INotifyPropertyChanged
{
	public int MyInt { get; set; }
}

public sealed class Observable : IObservable
{
	public event PropertyChangedEventHandler? PropertyChanged;

	private int _myInt;

	public int MyInt
	{
		get => _myInt;
		set
		{
			if (_myInt == value) return;
			_myInt = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(MyInt)));
		}
	}
}
