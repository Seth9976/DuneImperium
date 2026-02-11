using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B9 RID: 185
	[StructLayout(2)]
	public struct RTHandleStaticHelpers
	{
		// Token: 0x06000D01 RID: 3329 RVA: 0x0003C104 File Offset: 0x0003A304
		// Note: this type is marked as 'beforefieldinit'.
		static RTHandleStaticHelpers()
		{
			Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "RTHandleStaticHelpers");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr);
			RTHandleStaticHelpers.NativeFieldInfoPtr_s_RTHandleWrapper = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, "s_RTHandleWrapper");
			RTHandleStaticHelpers.NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, 100665169);
			RTHandleStaticHelpers.NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, 100665170);
		}

		// Token: 0x06000D02 RID: 3330 RVA: 0x0003C170 File Offset: 0x0003A370
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 972043, RefRangeEnd = 972047, XrefRangeStart = 972038, XrefRangeEnd = 972043, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRTHandleStaticWrapper(RenderTargetIdentifier rtId)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref rtId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RTHandleStaticHelpers.NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x0003C1A4 File Offset: 0x0003A3A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 972056, RefRangeEnd = 972057, XrefRangeStart = 972047, XrefRangeEnd = 972056, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetRTHandleUserManagedWrapper(ref RTHandle rtWrapper, RenderTargetIdentifier rtId)
		{
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = IL2CPP.Il2CppObjectBaseToPtr(rtWrapper);
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rtId;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(RTHandleStaticHelpers.NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0, 0, (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			rtWrapper = ((intPtr4 == 0) ? null : new RTHandle(intPtr4));
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00007BAE File Offset: 0x00005DAE
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<RTHandleStaticHelpers>.NativeClassPtr, ref this));
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x0003C200 File Offset: 0x0003A400
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00007BC0 File Offset: 0x00005DC0
		public unsafe static RTHandle s_RTHandleWrapper
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(RTHandleStaticHelpers.NativeFieldInfoPtr_s_RTHandleWrapper, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RTHandle>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(RTHandleStaticHelpers.NativeFieldInfoPtr_s_RTHandleWrapper, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040009BE RID: 2494
		private static readonly IntPtr NativeFieldInfoPtr_s_RTHandleWrapper;

		// Token: 0x040009BF RID: 2495
		private static readonly IntPtr NativeMethodInfoPtr_SetRTHandleStaticWrapper_Public_Static_Void_RenderTargetIdentifier_0;

		// Token: 0x040009C0 RID: 2496
		private static readonly IntPtr NativeMethodInfoPtr_SetRTHandleUserManagedWrapper_Public_Static_Void_byref_RTHandle_RenderTargetIdentifier_0;
	}
}
