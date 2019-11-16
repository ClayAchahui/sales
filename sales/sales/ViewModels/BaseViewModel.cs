
namespace sales.ViewModels
{
	using System.ComponentModel;
	using System.Runtime.CompilerServices;

	public class BaseViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void OnPropertyChanged([CallerMemberName] string propertyName=null)
		{
			this.PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
		}

		protected void SetValue<T>(ref T backingField,T value,[CallerMemberName] string property)
		{
			if (EqualityCompare<T>.Default.Equals(backingField,value))
			{
				return;
			}
			backingField = value;
			this.OnPropertyChanged(propertyName);
		}
	}
}
