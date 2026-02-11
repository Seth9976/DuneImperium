using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine.ResourceManagement;
using UnityEngine.ResourceManagement.Diagnostics;

namespace UnityEngine.AddressableAssets.Utility
{
	// Token: 0x0200001B RID: 27
	public class DiagnosticInfo : Object
	{
		// Token: 0x06000231 RID: 561 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		// Note: this type is marked as 'beforefieldinit'.
		static DiagnosticInfo()
		{
			Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Addressables.dll", "UnityEngine.AddressableAssets.Utility", "DiagnosticInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr);
			DiagnosticInfo.NativeFieldInfoPtr_DisplayName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr, "DisplayName");
			DiagnosticInfo.NativeFieldInfoPtr_ObjectId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr, "ObjectId");
			DiagnosticInfo.NativeFieldInfoPtr_Dependencies = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr, "Dependencies");
			DiagnosticInfo.NativeMethodInfoPtr_CreateEvent_Public_DiagnosticEvent_String_DiagnosticEventType_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr, 100663765);
			DiagnosticInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr, 100663766);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x0000F03C File Offset: 0x0000D23C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1162992, XrefRangeEnd = 1162993, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticEvent CreateEvent(string category, ResourceManager.DiagnosticEventType eventType, int frame, int val)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(category);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref eventType;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref frame;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref val;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticInfo.NativeMethodInfoPtr_CreateEvent_Public_DiagnosticEvent_String_DiagnosticEventType_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new DiagnosticEvent(intPtr);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x0000F0B0 File Offset: 0x0000D2B0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DiagnosticInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DiagnosticInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DiagnosticInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000029FD File Offset: 0x00000BFD
		public DiagnosticInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000235 RID: 565 RVA: 0x0000F0EC File Offset: 0x0000D2EC
		// (set) Token: 0x06000236 RID: 566 RVA: 0x00002A06 File Offset: 0x00000C06
		public unsafe string DisplayName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_DisplayName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_DisplayName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000237 RID: 567 RVA: 0x0000F114 File Offset: 0x0000D314
		// (set) Token: 0x06000238 RID: 568 RVA: 0x00002A25 File Offset: 0x00000C25
		public unsafe int ObjectId
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_ObjectId);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_ObjectId)) = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000239 RID: 569 RVA: 0x0000F13C File Offset: 0x0000D33C
		// (set) Token: 0x0600023A RID: 570 RVA: 0x00002A40 File Offset: 0x00000C40
		public unsafe Il2CppStructArray<int> Dependencies
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_Dependencies);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DiagnosticInfo.NativeFieldInfoPtr_Dependencies), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040001C8 RID: 456
		private static readonly IntPtr NativeFieldInfoPtr_DisplayName;

		// Token: 0x040001C9 RID: 457
		private static readonly IntPtr NativeFieldInfoPtr_ObjectId;

		// Token: 0x040001CA RID: 458
		private static readonly IntPtr NativeFieldInfoPtr_Dependencies;

		// Token: 0x040001CB RID: 459
		private static readonly IntPtr NativeMethodInfoPtr_CreateEvent_Public_DiagnosticEvent_String_DiagnosticEventType_Int32_Int32_0;

		// Token: 0x040001CC RID: 460
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
