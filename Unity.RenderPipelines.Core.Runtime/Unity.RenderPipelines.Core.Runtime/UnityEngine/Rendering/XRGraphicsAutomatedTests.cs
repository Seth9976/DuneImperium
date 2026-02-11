using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x02000119 RID: 281
	public static class XRGraphicsAutomatedTests : Object
	{
		// Token: 0x0600124B RID: 4683 RVA: 0x000530FC File Offset: 0x000512FC
		// Note: this type is marked as 'beforefieldinit'.
		static XRGraphicsAutomatedTests()
		{
			Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "XRGraphicsAutomatedTests");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr);
			XRGraphicsAutomatedTests.NativeFieldInfoPtr__enabled_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, "<enabled>k__BackingField");
			XRGraphicsAutomatedTests.NativeFieldInfoPtr_running = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, "running");
			XRGraphicsAutomatedTests.NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100665980);
			XRGraphicsAutomatedTests.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100665981);
			XRGraphicsAutomatedTests.NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRGraphicsAutomatedTests>.NativeClassPtr, 100665982);
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x0600124C RID: 4684 RVA: 0x00053190 File Offset: 0x00051390
		public unsafe static bool activatedFromCommandLine
		{
			[CallerCount(184)]
			[CachedScanResults(RefRangeStart = 25306, RefRangeEnd = 25490, XrefRangeStart = 25306, XrefRangeEnd = 25490, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphicsAutomatedTests.NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600124D RID: 4685 RVA: 0x000531C0 File Offset: 0x000513C0
		public unsafe static bool enabled
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979652, XrefRangeEnd = 979656, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphicsAutomatedTests.NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x000531F0 File Offset: 0x000513F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 979656, XrefRangeEnd = 979695, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void OverrideLayout(XRLayout layout, Camera camera)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(layout);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRGraphicsAutomatedTests.NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x00009613 File Offset: 0x00007813
		public XRGraphicsAutomatedTests(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001250 RID: 4688 RVA: 0x00053238 File Offset: 0x00051438
		// (set) Token: 0x06001251 RID: 4689 RVA: 0x0000961C File Offset: 0x0000781C
		public unsafe static bool _enabled_k__BackingField
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XRGraphicsAutomatedTests.NativeFieldInfoPtr__enabled_k__BackingField, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRGraphicsAutomatedTests.NativeFieldInfoPtr__enabled_k__BackingField, (void*)(&value));
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00053254 File Offset: 0x00051454
		// (set) Token: 0x06001253 RID: 4691 RVA: 0x0000962A File Offset: 0x0000782A
		public unsafe static bool running
		{
			get
			{
				bool flag;
				IL2CPP.il2cpp_field_static_get_value(XRGraphicsAutomatedTests.NativeFieldInfoPtr_running, (void*)(&flag));
				return flag;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(XRGraphicsAutomatedTests.NativeFieldInfoPtr_running, (void*)(&value));
			}
		}

		// Token: 0x04000DB0 RID: 3504
		private static readonly IntPtr NativeFieldInfoPtr__enabled_k__BackingField;

		// Token: 0x04000DB1 RID: 3505
		private static readonly IntPtr NativeFieldInfoPtr_running;

		// Token: 0x04000DB2 RID: 3506
		private static readonly IntPtr NativeMethodInfoPtr_get_activatedFromCommandLine_Private_Static_get_Boolean_0;

		// Token: 0x04000DB3 RID: 3507
		private static readonly IntPtr NativeMethodInfoPtr_get_enabled_Public_Static_get_Boolean_0;

		// Token: 0x04000DB4 RID: 3508
		private static readonly IntPtr NativeMethodInfoPtr_OverrideLayout_Internal_Static_Void_XRLayout_Camera_0;
	}
}
