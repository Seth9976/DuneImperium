using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000023 RID: 35
	public class GUIDebugger
	{
		// Token: 0x06000669 RID: 1641 RVA: 0x00004C85 File Offset: 0x00002E85
		public static void LogLayoutEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_Injected(ref rect, left, right, top, bottom, style);
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00004C95 File Offset: 0x00002E95
		public static void LogLayoutGroupEntry(Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_Injected(ref rect, left, right, top, bottom, style, isVertical);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00004CA7 File Offset: 0x00002EA7
		public static void LogLayoutEndGroup()
		{
			GUIDebugger.LogLayoutEndGroupDelegateField();
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00004CB3 File Offset: 0x00002EB3
		public static void LogBeginProperty(string targetTypeAssemblyQualifiedName, string path, Rect position)
		{
			GUIDebugger.LogBeginProperty_Injected(targetTypeAssemblyQualifiedName, path, ref position);
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x00004CBE File Offset: 0x00002EBE
		public static void LogEndProperty()
		{
			GUIDebugger.LogEndPropertyDelegateField();
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00004CCA File Offset: 0x00002ECA
		public static bool active
		{
			get
			{
				return GUIDebugger.get_activeDelegateField();
			}
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00004CD6 File Offset: 0x00002ED6
		public static void LogLayoutEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style)
		{
			GUIDebugger.LogLayoutEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style));
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00004CEF File Offset: 0x00002EEF
		public static void LogLayoutGroupEntry_Injected(ref Rect rect, int left, int right, int top, int bottom, GUIStyle style, bool isVertical)
		{
			GUIDebugger.LogLayoutGroupEntry_InjectedDelegateField(ref rect, left, right, top, bottom, IL2CPP.Il2CppObjectBaseToPtr(style), isVertical);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00004D0A File Offset: 0x00002F0A
		public static void LogBeginProperty_Injected(string targetTypeAssemblyQualifiedName, string path, ref Rect position)
		{
			GUIDebugger.LogBeginProperty_InjectedDelegateField(IL2CPP.ManagedStringToIl2Cpp(targetTypeAssemblyQualifiedName), IL2CPP.ManagedStringToIl2Cpp(path), ref position);
		}

		// Token: 0x04000380 RID: 896
		private static readonly GUIDebugger.LogLayoutEndGroupDelegate LogLayoutEndGroupDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEndGroupDelegate>("UnityEngine.GUIDebugger::LogLayoutEndGroup");

		// Token: 0x04000381 RID: 897
		private static readonly GUIDebugger.LogEndPropertyDelegate LogEndPropertyDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogEndPropertyDelegate>("UnityEngine.GUIDebugger::LogEndProperty");

		// Token: 0x04000382 RID: 898
		private static readonly GUIDebugger.get_activeDelegate get_activeDelegateField = IL2CPP.ResolveICall<GUIDebugger.get_activeDelegate>("UnityEngine.GUIDebugger::get_active");

		// Token: 0x04000383 RID: 899
		private static readonly GUIDebugger.LogLayoutEntry_InjectedDelegate LogLayoutEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutEntry_Injected");

		// Token: 0x04000384 RID: 900
		private static readonly GUIDebugger.LogLayoutGroupEntry_InjectedDelegate LogLayoutGroupEntry_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogLayoutGroupEntry_InjectedDelegate>("UnityEngine.GUIDebugger::LogLayoutGroupEntry_Injected");

		// Token: 0x04000385 RID: 901
		private static readonly GUIDebugger.LogBeginProperty_InjectedDelegate LogBeginProperty_InjectedDelegateField = IL2CPP.ResolveICall<GUIDebugger.LogBeginProperty_InjectedDelegate>("UnityEngine.GUIDebugger::LogBeginProperty_Injected");

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x0600078F RID: 1935
		private delegate void LogLayoutEndGroupDelegate();

		// Token: 0x020000B7 RID: 183
		// (Invoke) Token: 0x06000791 RID: 1937
		private delegate void LogEndPropertyDelegate();

		// Token: 0x020000B8 RID: 184
		// (Invoke) Token: 0x06000793 RID: 1939
		private delegate bool get_activeDelegate();

		// Token: 0x020000B9 RID: 185
		// (Invoke) Token: 0x06000795 RID: 1941
		private delegate void LogLayoutEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style);

		// Token: 0x020000BA RID: 186
		// (Invoke) Token: 0x06000797 RID: 1943
		private delegate void LogLayoutGroupEntry_InjectedDelegate(IntPtr rect, int left, int right, int top, int bottom, IntPtr style, bool isVertical);

		// Token: 0x020000BB RID: 187
		// (Invoke) Token: 0x06000799 RID: 1945
		private delegate void LogBeginProperty_InjectedDelegate(IntPtr targetTypeAssemblyQualifiedName, IntPtr path, IntPtr position);
	}
}
