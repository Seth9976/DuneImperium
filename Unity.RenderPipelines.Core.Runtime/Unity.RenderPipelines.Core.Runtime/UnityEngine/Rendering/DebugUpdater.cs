using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace UnityEngine.Rendering
{
	// Token: 0x02000069 RID: 105
	public class DebugUpdater : MonoBehaviour
	{
		// Token: 0x06000769 RID: 1897 RVA: 0x000297AC File Offset: 0x000279AC
		// Note: this type is marked as 'beforefieldinit'.
		static DebugUpdater()
		{
			Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "DebugUpdater");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr);
			DebugUpdater.NativeFieldInfoPtr_s_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, "s_Instance");
			DebugUpdater.NativeFieldInfoPtr_m_Orientation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, "m_Orientation");
			DebugUpdater.NativeFieldInfoPtr_m_RuntimeUiWasVisibleLastFrame = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, "m_RuntimeUiWasVisibleLastFrame");
			DebugUpdater.NativeMethodInfoPtr_RuntimeInit_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664473);
			DebugUpdater.NativeMethodInfoPtr_SetEnabled_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664474);
			DebugUpdater.NativeMethodInfoPtr_EnableRuntime_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664475);
			DebugUpdater.NativeMethodInfoPtr_DisableRuntime_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664476);
			DebugUpdater.NativeMethodInfoPtr_HandleInternalEventSystemComponents_Internal_Static_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664477);
			DebugUpdater.NativeMethodInfoPtr_EnsureExactlyOneEventSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664478);
			DebugUpdater.NativeMethodInfoPtr_DoAfterInputModuleUpdated_Private_IEnumerator_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664479);
			DebugUpdater.NativeMethodInfoPtr_CheckInputModuleExists_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664480);
			DebugUpdater.NativeMethodInfoPtr_CreateDebugEventSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664481);
			DebugUpdater.NativeMethodInfoPtr_DestroyDebugEventSystem_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664482);
			DebugUpdater.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664483);
			DebugUpdater.NativeMethodInfoPtr_RefreshRuntimeUINextFrame_Private_Static_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664484);
			DebugUpdater.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, 100664485);
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0002991C File Offset: 0x00027B1C
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RuntimeInit()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_RuntimeInit_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x00029944 File Offset: 0x00027B44
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 964623, RefRangeEnd = 964624, XrefRangeStart = 964597, XrefRangeEnd = 964623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetEnabled(bool enabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref enabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_SetEnabled_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00029978 File Offset: 0x00027B78
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964624, XrefRangeEnd = 964652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void EnableRuntime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_EnableRuntime_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000299A0 File Offset: 0x00027BA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964652, XrefRangeEnd = 964678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void DisableRuntime()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_DisableRuntime_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x000299C8 File Offset: 0x00027BC8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 964686, RefRangeEnd = 964688, XrefRangeStart = 964678, XrefRangeEnd = 964686, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void HandleInternalEventSystemComponents(bool uiEnabled)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref uiEnabled;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_HandleInternalEventSystemComponents_Internal_Static_Void_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x000299FC File Offset: 0x00027BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964688, XrefRangeEnd = 964733, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void EnsureExactlyOneEventSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_EnsureExactlyOneEventSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00029A30 File Offset: 0x00027C30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964733, XrefRangeEnd = 964738, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoAfterInputModuleUpdated(Action action)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_DoAfterInputModuleUpdated_Private_IEnumerator_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00029A80 File Offset: 0x00027C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964738, XrefRangeEnd = 964758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckInputModuleExists()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_CheckInputModuleExists_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00029AB4 File Offset: 0x00027CB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964758, XrefRangeEnd = 964767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CreateDebugEventSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_CreateDebugEventSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x00029AE8 File Offset: 0x00027CE8
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 964782, RefRangeEnd = 964784, XrefRangeStart = 964767, XrefRangeEnd = 964782, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void DestroyDebugEventSystem()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_DestroyDebugEventSystem_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x00029B1C File Offset: 0x00027D1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964784, XrefRangeEnd = 964828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Update()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00029B50 File Offset: 0x00027D50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964828, XrefRangeEnd = 964832, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static IEnumerator RefreshRuntimeUINextFrame()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr_RefreshRuntimeUINextFrame_Private_Static_IEnumerator_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00029B84 File Offset: 0x00027D84
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DebugUpdater()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00004F77 File Offset: 0x00003177
		public DebugUpdater(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00029BC0 File Offset: 0x00027DC0
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00004F80 File Offset: 0x00003180
		public unsafe static DebugUpdater s_Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(DebugUpdater.NativeFieldInfoPtr_s_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DebugUpdater>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(DebugUpdater.NativeFieldInfoPtr_s_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x00029BE8 File Offset: 0x00027DE8
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x00004F92 File Offset: 0x00003192
		public unsafe ScreenOrientation m_Orientation
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater.NativeFieldInfoPtr_m_Orientation);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater.NativeFieldInfoPtr_m_Orientation)) = value;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x00029C10 File Offset: 0x00027E10
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x00004FAD File Offset: 0x000031AD
		public unsafe bool m_RuntimeUiWasVisibleLastFrame
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater.NativeFieldInfoPtr_m_RuntimeUiWasVisibleLastFrame);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater.NativeFieldInfoPtr_m_RuntimeUiWasVisibleLastFrame)) = value;
			}
		}

		// Token: 0x04000575 RID: 1397
		private static readonly IntPtr NativeFieldInfoPtr_s_Instance;

		// Token: 0x04000576 RID: 1398
		private static readonly IntPtr NativeFieldInfoPtr_m_Orientation;

		// Token: 0x04000577 RID: 1399
		private static readonly IntPtr NativeFieldInfoPtr_m_RuntimeUiWasVisibleLastFrame;

		// Token: 0x04000578 RID: 1400
		private static readonly IntPtr NativeMethodInfoPtr_RuntimeInit_Private_Static_Void_0;

		// Token: 0x04000579 RID: 1401
		private static readonly IntPtr NativeMethodInfoPtr_SetEnabled_Internal_Static_Void_Boolean_0;

		// Token: 0x0400057A RID: 1402
		private static readonly IntPtr NativeMethodInfoPtr_EnableRuntime_Private_Static_Void_0;

		// Token: 0x0400057B RID: 1403
		private static readonly IntPtr NativeMethodInfoPtr_DisableRuntime_Private_Static_Void_0;

		// Token: 0x0400057C RID: 1404
		private static readonly IntPtr NativeMethodInfoPtr_HandleInternalEventSystemComponents_Internal_Static_Void_Boolean_0;

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeMethodInfoPtr_EnsureExactlyOneEventSystem_Private_Void_0;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeMethodInfoPtr_DoAfterInputModuleUpdated_Private_IEnumerator_Action_0;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeMethodInfoPtr_CheckInputModuleExists_Private_Void_0;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeMethodInfoPtr_CreateDebugEventSystem_Private_Void_0;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeMethodInfoPtr_DestroyDebugEventSystem_Private_Void_0;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr_RefreshRuntimeUINextFrame_Private_Static_IEnumerator_0;

		// Token: 0x04000584 RID: 1412
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020001B2 RID: 434
		[ObfuscatedName("UnityEngine.Rendering.DebugUpdater+<DoAfterInputModuleUpdated>d__9")]
		public sealed class _DoAfterInputModuleUpdated_d__9 : Object
		{
			// Token: 0x06001825 RID: 6181 RVA: 0x00066908 File Offset: 0x00064B08
			// Note: this type is marked as 'beforefieldinit'.
			static _DoAfterInputModuleUpdated_d__9()
			{
				Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, "<DoAfterInputModuleUpdated>d__9");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, "<>1__state");
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, "<>2__current");
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr_action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, "action");
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664486);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664487);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664488);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664489);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664490);
				DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr, 100664491);
			}

			// Token: 0x06001826 RID: 6182 RVA: 0x000669E8 File Offset: 0x00064BE8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoAfterInputModuleUpdated_d__9(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUpdater._DoAfterInputModuleUpdated_d__9>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001827 RID: 6183 RVA: 0x00066A30 File Offset: 0x00064C30
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001828 RID: 6184 RVA: 0x00066A64 File Offset: 0x00064C64
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964584, XrefRangeEnd = 964585, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006CD RID: 1741
			// (get) Token: 0x06001829 RID: 6185 RVA: 0x00066AA0 File Offset: 0x00064CA0
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600182A RID: 6186 RVA: 0x00066AE0 File Offset: 0x00064CE0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964585, XrefRangeEnd = 964590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006CE RID: 1742
			// (get) Token: 0x0600182B RID: 6187 RVA: 0x00066B14 File Offset: 0x00064D14
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600182C RID: 6188 RVA: 0x0000C056 File Offset: 0x0000A256
			public _DoAfterInputModuleUpdated_d__9(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x0600182D RID: 6189 RVA: 0x00066B54 File Offset: 0x00064D54
			// (set) Token: 0x0600182E RID: 6190 RVA: 0x0000C05F File Offset: 0x0000A25F
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x0600182F RID: 6191 RVA: 0x00066B7C File Offset: 0x00064D7C
			// (set) Token: 0x06001830 RID: 6192 RVA: 0x0000C07A File Offset: 0x0000A27A
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170006CC RID: 1740
			// (get) Token: 0x06001831 RID: 6193 RVA: 0x00066BAC File Offset: 0x00064DAC
			// (set) Token: 0x06001832 RID: 6194 RVA: 0x0000C099 File Offset: 0x0000A299
			public unsafe Action action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr_action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._DoAfterInputModuleUpdated_d__9.NativeFieldInfoPtr_action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400116F RID: 4463
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001170 RID: 4464
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04001171 RID: 4465
			private static readonly IntPtr NativeFieldInfoPtr_action;

			// Token: 0x04001172 RID: 4466
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04001173 RID: 4467
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001174 RID: 4468
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04001175 RID: 4469
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x04001176 RID: 4470
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x04001177 RID: 4471
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}

		// Token: 0x020001B3 RID: 435
		[ObfuscatedName("UnityEngine.Rendering.DebugUpdater+<RefreshRuntimeUINextFrame>d__14")]
		public sealed class _RefreshRuntimeUINextFrame_d__14 : Object
		{
			// Token: 0x06001833 RID: 6195 RVA: 0x00066BDC File Offset: 0x00064DDC
			// Note: this type is marked as 'beforefieldinit'.
			static _RefreshRuntimeUINextFrame_d__14()
			{
				Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DebugUpdater>.NativeClassPtr, "<RefreshRuntimeUINextFrame>d__14");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, "<>1__state");
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, "<>2__current");
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664492);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664493);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664494);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664495);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664496);
				DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr, 100664497);
			}

			// Token: 0x06001834 RID: 6196 RVA: 0x00066CA8 File Offset: 0x00064EA8
			[CallerCount(73)]
			[CachedScanResults(RefRangeStart = 39419, RefRangeEnd = 39492, XrefRangeStart = 39419, XrefRangeEnd = 39492, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _RefreshRuntimeUINextFrame_d__14(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugUpdater._RefreshRuntimeUINextFrame_d__14>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06001835 RID: 6197 RVA: 0x00066CF0 File Offset: 0x00064EF0
			[CallerCount(21425)]
			[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06001836 RID: 6198 RVA: 0x00066D24 File Offset: 0x00064F24
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964590, XrefRangeEnd = 964592, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170006D1 RID: 1745
			// (get) Token: 0x06001837 RID: 6199 RVA: 0x00066D60 File Offset: 0x00064F60
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x06001838 RID: 6200 RVA: 0x00066DA0 File Offset: 0x00064FA0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 964592, XrefRangeEnd = 964597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170006D2 RID: 1746
			// (get) Token: 0x06001839 RID: 6201 RVA: 0x00066DD4 File Offset: 0x00064FD4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(15)]
				[CachedScanResults(RefRangeStart = 3282, RefRangeEnd = 3297, XrefRangeStart = 3282, XrefRangeEnd = 3297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x0600183A RID: 6202 RVA: 0x0000C0B8 File Offset: 0x0000A2B8
			public _RefreshRuntimeUINextFrame_d__14(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170006CF RID: 1743
			// (get) Token: 0x0600183B RID: 6203 RVA: 0x00066E14 File Offset: 0x00065014
			// (set) Token: 0x0600183C RID: 6204 RVA: 0x0000C0C1 File Offset: 0x0000A2C1
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170006D0 RID: 1744
			// (get) Token: 0x0600183D RID: 6205 RVA: 0x00066E3C File Offset: 0x0006503C
			// (set) Token: 0x0600183E RID: 6206 RVA: 0x0000C0DC File Offset: 0x0000A2DC
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DebugUpdater._RefreshRuntimeUINextFrame_d__14.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001178 RID: 4472
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04001179 RID: 4473
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x0400117A RID: 4474
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x0400117B RID: 4475
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400117C RID: 4476
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x0400117D RID: 4477
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400117E RID: 4478
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400117F RID: 4479
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
