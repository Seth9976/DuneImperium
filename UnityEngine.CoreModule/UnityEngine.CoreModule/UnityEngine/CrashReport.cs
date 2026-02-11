using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace UnityEngine
{
	// Token: 0x020002C5 RID: 709
	public sealed class CrashReport
	{
		// Token: 0x06002CD5 RID: 11477 RVA: 0x00011807 File Offset: 0x0000FA07
		public static int Compare(CrashReport c1, CrashReport c2)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CD6 RID: 11478 RVA: 0x00011814 File Offset: 0x0000FA14
		public static void PopulateReports()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06002CD7 RID: 11479 RVA: 0x00011821 File Offset: 0x0000FA21
		public static Il2CppReferenceArray<CrashReport> reports
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06002CD8 RID: 11480 RVA: 0x0001182E File Offset: 0x0000FA2E
		public static CrashReport lastReport
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002CD9 RID: 11481 RVA: 0x0001183B File Offset: 0x0000FA3B
		public static void RemoveAll()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CDA RID: 11482 RVA: 0x00011848 File Offset: 0x0000FA48
		public void Remove()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06002CDB RID: 11483 RVA: 0x000B2D50 File Offset: 0x000B0F50
		public static Il2CppStringArray GetReports()
		{
			IntPtr intPtr = CrashReport.GetReportsDelegateField();
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06002CDC RID: 11484 RVA: 0x000B2D78 File Offset: 0x000B0F78
		public static string GetReportData(string id, out double secondsSinceUnixEpoch)
		{
			IntPtr intPtr = CrashReport.GetReportDataDelegateField(IL2CPP.ManagedStringToIl2Cpp(id), out secondsSinceUnixEpoch);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06002CDD RID: 11485 RVA: 0x00011855 File Offset: 0x0000FA55
		public static bool RemoveReport(string id)
		{
			return CrashReport.RemoveReportDelegateField(IL2CPP.ManagedStringToIl2Cpp(id));
		}

		// Token: 0x0400283D RID: 10301
		private static readonly CrashReport.GetReportsDelegate GetReportsDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportsDelegate>("UnityEngine.CrashReport::GetReports");

		// Token: 0x0400283E RID: 10302
		private static readonly CrashReport.GetReportDataDelegate GetReportDataDelegateField = IL2CPP.ResolveICall<CrashReport.GetReportDataDelegate>("UnityEngine.CrashReport::GetReportData");

		// Token: 0x0400283F RID: 10303
		private static readonly CrashReport.RemoveReportDelegate RemoveReportDelegateField = IL2CPP.ResolveICall<CrashReport.RemoveReportDelegate>("UnityEngine.CrashReport::RemoveReport");

		// Token: 0x02000AE2 RID: 2786
		// (Invoke) Token: 0x06003EBB RID: 16059
		private delegate IntPtr GetReportsDelegate();

		// Token: 0x02000AE3 RID: 2787
		// (Invoke) Token: 0x06003EBD RID: 16061
		private delegate IntPtr GetReportDataDelegate(IntPtr id, [Out] IntPtr secondsSinceUnixEpoch);

		// Token: 0x02000AE4 RID: 2788
		// (Invoke) Token: 0x06003EBF RID: 16063
		private delegate bool RemoveReportDelegate(IntPtr id);
	}
}
