using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace QtSampleApp;

public sealed class CustomObservableCollection<T> :
	IList<T>,
	IList,
	IReadOnlyList<T>,
	INotifyPropertyChanged,
	INotifyCollectionChanged
	where T : class
{
	public event PropertyChangedEventHandler? PropertyChanged;

	public event NotifyCollectionChangedEventHandler? CollectionChanged;

	public IEnumerator<T> GetEnumerator()
		=> throw new NotImplementedException();

	IEnumerator IEnumerable.GetEnumerator()
		=> throw new NotImplementedException();

	public void Add(T item)
		=> throw new NotImplementedException();

	public int Add(object? value)
		=> throw new NotImplementedException();

	void IList.Clear()
		=> throw new NotImplementedException();

	public bool Contains(object? value)
		=> throw new NotImplementedException();

	public int IndexOf(object? value)
		=> throw new NotImplementedException();

	public void Insert(int index, object? value)
		=> throw new NotImplementedException();

	public void Remove(object? value)
		=> throw new NotImplementedException();

	void IList.RemoveAt(int index)
		=> throw new NotImplementedException();

	public bool IsFixedSize
		=> throw new NotImplementedException();

	bool IList.IsReadOnly
		=> throw new NotImplementedException();

	object? IList.this[int index]
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}

	void ICollection<T>.Clear()
		=> throw new NotImplementedException();

	public bool Contains(T item)
		=> throw new NotImplementedException();

	public void CopyTo(T[] array, int arrayIndex)
		=> throw new NotImplementedException();

	public bool Remove(T item)
		=> throw new NotImplementedException();

	public void CopyTo(Array array, int index)
		=> throw new NotImplementedException();

	int ICollection.Count
		=> throw new NotImplementedException();

	bool ICollection.IsSynchronized
		=> throw new NotImplementedException();

	object ICollection.SyncRoot
		=> throw new NotImplementedException();

	int ICollection<T>.Count
		=> throw new NotImplementedException();

	bool ICollection<T>.IsReadOnly
		=> throw new NotImplementedException();

	public int IndexOf(T item)
		=> throw new NotImplementedException();

	public void Insert(int index, T item)
		=> throw new NotImplementedException();

	void IList<T>.RemoveAt(int index)
		=> throw new NotImplementedException();

	public T this[int index]
	{
		get => throw new NotImplementedException();
		set => throw new NotImplementedException();
	}

	int IReadOnlyCollection<T>.Count
		=> throw new NotImplementedException();
}
