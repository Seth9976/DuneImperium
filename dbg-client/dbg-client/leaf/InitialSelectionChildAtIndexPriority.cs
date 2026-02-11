using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using lib.canis.src.util;

namespace leaf
{
	// Token: 0x02000019 RID: 25
	public class InitialSelectionChildAtIndexPriority : InitialSelectionPriority
	{
		// Token: 0x060000DF RID: 223 RVA: 0x000204AC File Offset: 0x0001E6AC
		// Note: this type is marked as 'beforefieldinit'.
		static InitialSelectionChildAtIndexPriority()
		{
			Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr = IL2CPP.GetIl2CppClass("dbg-client.dll", "leaf", "InitialSelectionChildAtIndexPriority");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr);
			InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr, "index");
			InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr, "priority");
			InitialSelectionChildAtIndexPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr, 100663462);
			InitialSelectionChildAtIndexPriority.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr, 100663463);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0002052C File Offset: 0x0001E72C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496274, XrefRangeEnd = 496290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int getPriority()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InitialSelectionChildAtIndexPriority.NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00020574 File Offset: 0x0001E774
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 496290, XrefRangeEnd = 496291, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InitialSelectionChildAtIndexPriority()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InitialSelectionChildAtIndexPriority>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InitialSelectionChildAtIndexPriority.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x000025C5 File Offset: 0x000007C5
		public InitialSelectionChildAtIndexPriority(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000205B0 File Offset: 0x0001E7B0
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x000025CE File Offset: 0x000007CE
		public unsafe int index
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_index);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_index)) = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x000205D8 File Offset: 0x0001E7D8
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x000025E9 File Offset: 0x000007E9
		public unsafe int priority
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_priority);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InitialSelectionChildAtIndexPriority.NativeFieldInfoPtr_priority)) = value;
			}
		}

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeFieldInfoPtr_index;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeFieldInfoPtr_priority;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_getPriority_Protected_Virtual_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
