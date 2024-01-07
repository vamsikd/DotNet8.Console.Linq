using DotNet8.Console.Linq;

var persons = Person.GetSeedData();

#region Grouping
//Grouping.GrpBySimple(persons);
////Grouping.LookUpSimple(persons);
//Grouping.ToDictionarySimple(persons);
//Grouping.GrpByCompnayNameWithMultiSelect(persons);
//Grouping.GrpByCompnayNameWithSelect(persons);
//Grouping.GrpByCompnayNameWithSelectMany(persons);
//Grouping.GrpByWithSelectManyOrdering(persons);
#endregion

#region Filtering
//Filtering.DistinctElementSimple(persons);
Filtering.DistinctElementComparer(persons);
Filtering.DistinctByElementComparer(persons);
#endregion

