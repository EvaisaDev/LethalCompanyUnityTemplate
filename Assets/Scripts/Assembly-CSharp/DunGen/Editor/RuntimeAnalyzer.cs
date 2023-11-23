using System.Diagnostics;
using System.Text;
using DunGen.Analysis;
using DunGen.Graph;
using UnityEngine;

namespace DunGen.Editor
{
	[AddComponentMenu("DunGen/Analysis/Runtime Analyzer")]
	public sealed class RuntimeAnalyzer : MonoBehaviour
	{
		public DungeonFlow DungeonFlow;

		public int Iterations;

		public int MaxFailedAttempts;

		public bool RunOnStart;

		public float MaximumAnalysisTime;

		private DungeonGenerator generator;

		private GenerationAnalysis analysis;

		private StringBuilder infoText;

		private bool finishedEarly;

		private bool prevShouldRandomizeSeed;

		private int targetIterations;

		private int remainingIterations;

		private Stopwatch analysisTime;

		private bool generateNextFrame;

		private int currentIterations => 0;

		private void Start()
		{
		}

		public void Analyze()
		{
		}

		private void Update()
		{
		}

		private void CompleteAnalysis()
		{
		}

		private void OnGenerationStatusChanged(DungeonGenerator generator, GenerationStatus status)
		{
		}

		private void OnAnalysisComplete()
		{
		}

		private void OnGUI()
		{
		}
	}
}
