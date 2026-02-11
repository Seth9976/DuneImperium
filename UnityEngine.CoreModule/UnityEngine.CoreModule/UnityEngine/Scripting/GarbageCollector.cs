using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Scripting
{
	// Token: 0x02000326 RID: 806
	public static class GarbageCollector
	{
		// Token: 0x06002E16 RID: 11798 RVA: 0x000126BD File Offset: 0x000108BD
		public static void add_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x000126CA File Offset: 0x000108CA
		public static void remove_GCModeChanged(Action<GarbageCollector.Mode> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x06002E18 RID: 11800 RVA: 0x000B4A68 File Offset: 0x000B2C68
		// (set) Token: 0x06002E19 RID: 11801 RVA: 0x000126D7 File Offset: 0x000108D7
		public static GarbageCollector.Mode GCMode
		{
			get
			{
				return GarbageCollector.GetMode();
			}
			set
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002E1A RID: 11802 RVA: 0x000126E4 File Offset: 0x000108E4
		public static void SetMode(GarbageCollector.Mode mode)
		{
			GarbageCollector.SetModeDelegateField(mode);
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x000126F1 File Offset: 0x000108F1
		public static GarbageCollector.Mode GetMode()
		{
			return GarbageCollector.GetModeDelegateField();
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x06002E1C RID: 11804 RVA: 0x000126FD File Offset: 0x000108FD
		public static bool isIncremental
		{
			get
			{
				return GarbageCollector.get_isIncrementalDelegateField();
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x00012709 File Offset: 0x00010909
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x00012715 File Offset: 0x00010915
		public static ulong incrementalTimeSliceNanoseconds
		{
			get
			{
				return GarbageCollector.get_incrementalTimeSliceNanosecondsDelegateField();
			}
			set
			{
				GarbageCollector.set_incrementalTimeSliceNanosecondsDelegateField(value);
			}
		}

		// Token: 0x06002E1F RID: 11807 RVA: 0x00012722 File Offset: 0x00010922
		public static bool CollectIncremental([Optional] ulong nanoseconds)
		{
			return GarbageCollector.CollectIncrementalDelegateField(nanoseconds);
		}

		// Token: 0x040029A4 RID: 10660
		private static readonly GarbageCollector.SetModeDelegate SetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.SetModeDelegate>("UnityEngine.Scripting.GarbageCollector::SetMode");

		// Token: 0x040029A5 RID: 10661
		private static readonly GarbageCollector.GetModeDelegate GetModeDelegateField = IL2CPP.ResolveICall<GarbageCollector.GetModeDelegate>("UnityEngine.Scripting.GarbageCollector::GetMode");

		// Token: 0x040029A6 RID: 10662
		private static readonly GarbageCollector.get_isIncrementalDelegate get_isIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_isIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::get_isIncremental");

		// Token: 0x040029A7 RID: 10663
		private static readonly GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate get_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.get_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::get_incrementalTimeSliceNanoseconds");

		// Token: 0x040029A8 RID: 10664
		private static readonly GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate set_incrementalTimeSliceNanosecondsDelegateField = IL2CPP.ResolveICall<GarbageCollector.set_incrementalTimeSliceNanosecondsDelegate>("UnityEngine.Scripting.GarbageCollector::set_incrementalTimeSliceNanoseconds");

		// Token: 0x040029A9 RID: 10665
		private static readonly GarbageCollector.CollectIncrementalDelegate CollectIncrementalDelegateField = IL2CPP.ResolveICall<GarbageCollector.CollectIncrementalDelegate>("UnityEngine.Scripting.GarbageCollector::CollectIncremental");

		// Token: 0x02000B7A RID: 2938
		public enum Mode
		{
			// Token: 0x04002DB5 RID: 11701
			Disabled,
			// Token: 0x04002DB6 RID: 11702
			Enabled,
			// Token: 0x04002DB7 RID: 11703
			Manual
		}

		// Token: 0x02000B7B RID: 2939
		// (Invoke) Token: 0x06003FE9 RID: 16361
		private delegate void SetModeDelegate(GarbageCollector.Mode mode);

		// Token: 0x02000B7C RID: 2940
		// (Invoke) Token: 0x06003FEB RID: 16363
		private delegate GarbageCollector.Mode GetModeDelegate();

		// Token: 0x02000B7D RID: 2941
		// (Invoke) Token: 0x06003FED RID: 16365
		private delegate bool get_isIncrementalDelegate();

		// Token: 0x02000B7E RID: 2942
		// (Invoke) Token: 0x06003FEF RID: 16367
		private delegate ulong get_incrementalTimeSliceNanosecondsDelegate();

		// Token: 0x02000B7F RID: 2943
		// (Invoke) Token: 0x06003FF1 RID: 16369
		private delegate void set_incrementalTimeSliceNanosecondsDelegate(ulong value);

		// Token: 0x02000B80 RID: 2944
		// (Invoke) Token: 0x06003FF3 RID: 16371
		private delegate bool CollectIncrementalDelegate(ulong nanoseconds);
	}
}
