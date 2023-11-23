using System.Collections.Generic;
using UnityEngine;

namespace DunGen
{
	public class ChanceTable<T>
	{
		[SerializeField]
		public List<Chance<T>> Weights;

		public void Add(T value, float weight)
		{
		}

		public void Remove(T value)
		{
		}

		public T GetRandom(RandomStream random)
		{
			return default(T);
		}

		public static TVal GetCombinedRandom<TVal, TChance>(RandomStream random, params ChanceTable<TVal>[] tables)
		{
			return default(TVal);
		}
	}
}
