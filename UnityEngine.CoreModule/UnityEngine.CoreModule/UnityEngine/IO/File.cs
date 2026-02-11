using System;
using Il2CppInterop.Runtime;

namespace UnityEngine.IO
{
	// Token: 0x02000350 RID: 848
	public static class File
	{
		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x000B4D30 File Offset: 0x000B2F30
		public static ulong totalOpenCalls
		{
			get
			{
				return File.GetTotalOpenCalls();
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x000B4D48 File Offset: 0x000B2F48
		public static ulong totalCloseCalls
		{
			get
			{
				return File.GetTotalCloseCalls();
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06002E46 RID: 11846 RVA: 0x000B4D60 File Offset: 0x000B2F60
		public static ulong totalReadCalls
		{
			get
			{
				return File.GetTotalReadCalls();
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x000B4D78 File Offset: 0x000B2F78
		public static ulong totalWriteCalls
		{
			get
			{
				return File.GetTotalWriteCalls();
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x000B4D90 File Offset: 0x000B2F90
		public static ulong totalSeekCalls
		{
			get
			{
				return File.GetTotalSeekCalls();
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000B4DA8 File Offset: 0x000B2FA8
		public static ulong totalZeroSeekCalls
		{
			get
			{
				return File.GetTotalZeroSeekCalls();
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06002E4A RID: 11850 RVA: 0x000B4DC0 File Offset: 0x000B2FC0
		public static ulong totalFilesOpened
		{
			get
			{
				return File.GetTotalFilesOpened();
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000B4DD8 File Offset: 0x000B2FD8
		public static ulong totalFilesClosed
		{
			get
			{
				return File.GetTotalFilesClosed();
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06002E4C RID: 11852 RVA: 0x000B4DF0 File Offset: 0x000B2FF0
		public static ulong totalBytesRead
		{
			get
			{
				return File.GetTotalBytesRead();
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x000B4E08 File Offset: 0x000B3008
		public static ulong totalBytesWritten
		{
			get
			{
				return File.GetTotalBytesWritten();
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x000B4E20 File Offset: 0x000B3020
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x000128C8 File Offset: 0x00010AC8
		public static bool recordZeroSeeks
		{
			get
			{
				return File.GetRecordZeroSeeks();
			}
			set
			{
				File.SetRecordZeroSeeks(value);
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06002E50 RID: 11856 RVA: 0x000B4E38 File Offset: 0x000B3038
		// (set) Token: 0x06002E51 RID: 11857 RVA: 0x000128D2 File Offset: 0x00010AD2
		public static ThreadIORestrictionMode MainThreadIORestrictionMode
		{
			get
			{
				return File.GetMainThreadFileIORestriction();
			}
			set
			{
				File.SetMainThreadFileIORestriction(value);
			}
		}

		// Token: 0x06002E52 RID: 11858 RVA: 0x000128DC File Offset: 0x00010ADC
		public static void SetRecordZeroSeeks(bool enable)
		{
			File.SetRecordZeroSeeksDelegateField(enable);
		}

		// Token: 0x06002E53 RID: 11859 RVA: 0x000128E9 File Offset: 0x00010AE9
		public static bool GetRecordZeroSeeks()
		{
			return File.GetRecordZeroSeeksDelegateField();
		}

		// Token: 0x06002E54 RID: 11860 RVA: 0x000128F5 File Offset: 0x00010AF5
		public static ulong GetTotalOpenCalls()
		{
			return File.GetTotalOpenCallsDelegateField();
		}

		// Token: 0x06002E55 RID: 11861 RVA: 0x00012901 File Offset: 0x00010B01
		public static ulong GetTotalCloseCalls()
		{
			return File.GetTotalCloseCallsDelegateField();
		}

		// Token: 0x06002E56 RID: 11862 RVA: 0x0001290D File Offset: 0x00010B0D
		public static ulong GetTotalReadCalls()
		{
			return File.GetTotalReadCallsDelegateField();
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00012919 File Offset: 0x00010B19
		public static ulong GetTotalWriteCalls()
		{
			return File.GetTotalWriteCallsDelegateField();
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x00012925 File Offset: 0x00010B25
		public static ulong GetTotalSeekCalls()
		{
			return File.GetTotalSeekCallsDelegateField();
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x00012931 File Offset: 0x00010B31
		public static ulong GetTotalZeroSeekCalls()
		{
			return File.GetTotalZeroSeekCallsDelegateField();
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0001293D File Offset: 0x00010B3D
		public static ulong GetTotalFilesOpened()
		{
			return File.GetTotalFilesOpenedDelegateField();
		}

		// Token: 0x06002E5B RID: 11867 RVA: 0x00012949 File Offset: 0x00010B49
		public static ulong GetTotalFilesClosed()
		{
			return File.GetTotalFilesClosedDelegateField();
		}

		// Token: 0x06002E5C RID: 11868 RVA: 0x00012955 File Offset: 0x00010B55
		public static ulong GetTotalBytesRead()
		{
			return File.GetTotalBytesReadDelegateField();
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00012961 File Offset: 0x00010B61
		public static ulong GetTotalBytesWritten()
		{
			return File.GetTotalBytesWrittenDelegateField();
		}

		// Token: 0x06002E5E RID: 11870 RVA: 0x0001296D File Offset: 0x00010B6D
		public static void SetMainThreadFileIORestriction(ThreadIORestrictionMode mode)
		{
			File.SetMainThreadFileIORestrictionDelegateField(mode);
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x0001297A File Offset: 0x00010B7A
		public static ThreadIORestrictionMode GetMainThreadFileIORestriction()
		{
			return File.GetMainThreadFileIORestrictionDelegateField();
		}

		// Token: 0x04002A2E RID: 10798
		private static readonly File.SetRecordZeroSeeksDelegate SetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.SetRecordZeroSeeksDelegate>("UnityEngine.IO.File::SetRecordZeroSeeks");

		// Token: 0x04002A2F RID: 10799
		private static readonly File.GetRecordZeroSeeksDelegate GetRecordZeroSeeksDelegateField = IL2CPP.ResolveICall<File.GetRecordZeroSeeksDelegate>("UnityEngine.IO.File::GetRecordZeroSeeks");

		// Token: 0x04002A30 RID: 10800
		private static readonly File.GetTotalOpenCallsDelegate GetTotalOpenCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalOpenCallsDelegate>("UnityEngine.IO.File::GetTotalOpenCalls");

		// Token: 0x04002A31 RID: 10801
		private static readonly File.GetTotalCloseCallsDelegate GetTotalCloseCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalCloseCallsDelegate>("UnityEngine.IO.File::GetTotalCloseCalls");

		// Token: 0x04002A32 RID: 10802
		private static readonly File.GetTotalReadCallsDelegate GetTotalReadCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalReadCallsDelegate>("UnityEngine.IO.File::GetTotalReadCalls");

		// Token: 0x04002A33 RID: 10803
		private static readonly File.GetTotalWriteCallsDelegate GetTotalWriteCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalWriteCallsDelegate>("UnityEngine.IO.File::GetTotalWriteCalls");

		// Token: 0x04002A34 RID: 10804
		private static readonly File.GetTotalSeekCallsDelegate GetTotalSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalSeekCallsDelegate>("UnityEngine.IO.File::GetTotalSeekCalls");

		// Token: 0x04002A35 RID: 10805
		private static readonly File.GetTotalZeroSeekCallsDelegate GetTotalZeroSeekCallsDelegateField = IL2CPP.ResolveICall<File.GetTotalZeroSeekCallsDelegate>("UnityEngine.IO.File::GetTotalZeroSeekCalls");

		// Token: 0x04002A36 RID: 10806
		private static readonly File.GetTotalFilesOpenedDelegate GetTotalFilesOpenedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesOpenedDelegate>("UnityEngine.IO.File::GetTotalFilesOpened");

		// Token: 0x04002A37 RID: 10807
		private static readonly File.GetTotalFilesClosedDelegate GetTotalFilesClosedDelegateField = IL2CPP.ResolveICall<File.GetTotalFilesClosedDelegate>("UnityEngine.IO.File::GetTotalFilesClosed");

		// Token: 0x04002A38 RID: 10808
		private static readonly File.GetTotalBytesReadDelegate GetTotalBytesReadDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesReadDelegate>("UnityEngine.IO.File::GetTotalBytesRead");

		// Token: 0x04002A39 RID: 10809
		private static readonly File.GetTotalBytesWrittenDelegate GetTotalBytesWrittenDelegateField = IL2CPP.ResolveICall<File.GetTotalBytesWrittenDelegate>("UnityEngine.IO.File::GetTotalBytesWritten");

		// Token: 0x04002A3A RID: 10810
		private static readonly File.SetMainThreadFileIORestrictionDelegate SetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.SetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::SetMainThreadFileIORestriction");

		// Token: 0x04002A3B RID: 10811
		private static readonly File.GetMainThreadFileIORestrictionDelegate GetMainThreadFileIORestrictionDelegateField = IL2CPP.ResolveICall<File.GetMainThreadFileIORestrictionDelegate>("UnityEngine.IO.File::GetMainThreadFileIORestriction");

		// Token: 0x02000B91 RID: 2961
		// (Invoke) Token: 0x06004013 RID: 16403
		private delegate void SetRecordZeroSeeksDelegate(bool enable);

		// Token: 0x02000B92 RID: 2962
		// (Invoke) Token: 0x06004015 RID: 16405
		private delegate bool GetRecordZeroSeeksDelegate();

		// Token: 0x02000B93 RID: 2963
		// (Invoke) Token: 0x06004017 RID: 16407
		private delegate ulong GetTotalOpenCallsDelegate();

		// Token: 0x02000B94 RID: 2964
		// (Invoke) Token: 0x06004019 RID: 16409
		private delegate ulong GetTotalCloseCallsDelegate();

		// Token: 0x02000B95 RID: 2965
		// (Invoke) Token: 0x0600401B RID: 16411
		private delegate ulong GetTotalReadCallsDelegate();

		// Token: 0x02000B96 RID: 2966
		// (Invoke) Token: 0x0600401D RID: 16413
		private delegate ulong GetTotalWriteCallsDelegate();

		// Token: 0x02000B97 RID: 2967
		// (Invoke) Token: 0x0600401F RID: 16415
		private delegate ulong GetTotalSeekCallsDelegate();

		// Token: 0x02000B98 RID: 2968
		// (Invoke) Token: 0x06004021 RID: 16417
		private delegate ulong GetTotalZeroSeekCallsDelegate();

		// Token: 0x02000B99 RID: 2969
		// (Invoke) Token: 0x06004023 RID: 16419
		private delegate ulong GetTotalFilesOpenedDelegate();

		// Token: 0x02000B9A RID: 2970
		// (Invoke) Token: 0x06004025 RID: 16421
		private delegate ulong GetTotalFilesClosedDelegate();

		// Token: 0x02000B9B RID: 2971
		// (Invoke) Token: 0x06004027 RID: 16423
		private delegate ulong GetTotalBytesReadDelegate();

		// Token: 0x02000B9C RID: 2972
		// (Invoke) Token: 0x06004029 RID: 16425
		private delegate ulong GetTotalBytesWrittenDelegate();

		// Token: 0x02000B9D RID: 2973
		// (Invoke) Token: 0x0600402B RID: 16427
		private delegate void SetMainThreadFileIORestrictionDelegate(ThreadIORestrictionMode mode);

		// Token: 0x02000B9E RID: 2974
		// (Invoke) Token: 0x0600402D RID: 16429
		private delegate ThreadIORestrictionMode GetMainThreadFileIORestrictionDelegate();
	}
}
