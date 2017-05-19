using System.Collections.Generic;

namespace Camping
{
	public class DashboardViewModel
	{
		public List<SampleCategory> Items { 
			get 
			{ 
				return SamplesDefinition.SamplesCategoryList;
			} 
		}
	}
}