using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
	// Token: 0x02000007 RID: 7
	public class XRLayout : Object
	{
		// Token: 0x06000061 RID: 97 RVA: 0x0000F364 File Offset: 0x0000D564
		// Note: this type is marked as 'beforefieldinit'.
		static XRLayout()
		{
			Il2CppClassPointerStore<XRLayout>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Experimental.Rendering", "XRLayout");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<XRLayout>.NativeClassPtr);
			XRLayout.NativeFieldInfoPtr_m_ActivePasses = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, "m_ActivePasses");
			XRLayout.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663328);
			XRLayout.NativeMethodInfoPtr_ReconfigurePass_Public_Void_XRPass_Camera_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663329);
			XRLayout.NativeMethodInfoPtr_GetActivePasses_Public_List_1_ValueTuple_2_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663330);
			XRLayout.NativeMethodInfoPtr_AddPass_Internal_Void_Camera_XRPass_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663331);
			XRLayout.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663332);
			XRLayout.NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663333);
			XRLayout.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<XRLayout>.NativeClassPtr, 100663334);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000F434 File Offset: 0x0000D634
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953341, RefRangeEnd = 953342, XrefRangeStart = 953322, XrefRangeEnd = 953341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddCamera(Camera camera, bool enableXR)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref enableXR;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000F484 File Offset: 0x0000D684
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 953348, RefRangeEnd = 953350, XrefRangeStart = 953342, XrefRangeEnd = 953348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReconfigurePass(XRPass xrPass, Camera camera)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(camera);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_ReconfigurePass_Public_Void_XRPass_Camera_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe List<ValueTuple<Camera, XRPass>> GetActivePasses()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_GetActivePasses_Public_List_1_ValueTuple_2_Camera_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Camera, XRPass>>>(intPtr3) : null;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000F518 File Offset: 0x0000D718
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 953357, RefRangeEnd = 953360, XrefRangeStart = 953350, XrefRangeEnd = 953357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void AddPass(Camera camera, XRPass xrPass)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(camera);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(xrPass);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_AddPass_Internal_Void_Camera_XRPass_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000F56C File Offset: 0x0000D76C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953360, XrefRangeEnd = 953371, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000F5A0 File Offset: 0x0000D7A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 953437, RefRangeEnd = 953438, XrefRangeStart = 953371, XrefRangeEnd = 953437, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void LogDebugInfo()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 953438, XrefRangeEnd = 953446, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe XRLayout()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<XRLayout>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(XRLayout.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000022FA File Offset: 0x000004FA
		public XRLayout(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600006A RID: 106 RVA: 0x0000F610 File Offset: 0x0000D810
		// (set) Token: 0x0600006B RID: 107 RVA: 0x00002303 File Offset: 0x00000503
		public unsafe List<ValueTuple<Camera, XRPass>> m_ActivePasses
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRLayout.NativeFieldInfoPtr_m_ActivePasses);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<ValueTuple<Camera, XRPass>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(XRLayout.NativeFieldInfoPtr_m_ActivePasses), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003B RID: 59
		private static readonly IntPtr NativeFieldInfoPtr_m_ActivePasses;

		// Token: 0x0400003C RID: 60
		private static readonly IntPtr NativeMethodInfoPtr_AddCamera_Public_Void_Camera_Boolean_0;

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeMethodInfoPtr_ReconfigurePass_Public_Void_XRPass_Camera_0;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr_GetActivePasses_Public_List_1_ValueTuple_2_Camera_XRPass_0;

		// Token: 0x0400003F RID: 63
		private static readonly IntPtr NativeMethodInfoPtr_AddPass_Internal_Void_Camera_XRPass_0;

		// Token: 0x04000040 RID: 64
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

		// Token: 0x04000041 RID: 65
		private static readonly IntPtr NativeMethodInfoPtr_LogDebugInfo_Internal_Void_0;

		// Token: 0x04000042 RID: 66
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
