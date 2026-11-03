using System.Collections.ObjectModel;

namespace QtSampleApp.Cases;

public sealed class ReferencingClass
{
	// By itself: this is fine.
	public ProblemClass ProblemObject { get; set; }

	// By itself: this causes C++ errors.
	public ObservableCollection<ProblemClass> ProblemObjectObservableCollection { get; set; }

	// By itself: this causes C++ errors.
	public ProblemClass[] ProblemObjectArray { get; set; }
}

public sealed class ProblemClass
{
	public Action ProblemProperty { get; }
}
