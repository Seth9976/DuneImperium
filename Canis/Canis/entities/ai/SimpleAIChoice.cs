using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.entities.ai
{
	// Token: 0x02000113 RID: 275
	public class SimpleAIChoice : Object
	{
		// Token: 0x06000C7D RID: 3197 RVA: 0x0004F420 File Offset: 0x0004D620
		// Note: this type is marked as 'beforefieldinit'.
		static SimpleAIChoice()
		{
			Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities.ai", "SimpleAIChoice");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr);
			SimpleAIChoice.NativeFieldInfoPtr_rank = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr, "rank");
			SimpleAIChoice.NativeFieldInfoPtr_target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr, "target");
			SimpleAIChoice.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr, 100666108);
			SimpleAIChoice.NativeMethodInfoPtr_IsDefaultChoice_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr, 100666109);
		}

		// Token: 0x06000C7E RID: 3198 RVA: 0x0004F4A0 File Offset: 0x0004D6A0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 573396, RefRangeEnd = 573397, XrefRangeStart = 573394, XrefRangeEnd = 573396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SimpleAIChoice(EntityID orderID, int amt)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SimpleAIChoice>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(orderID);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref amt;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleAIChoice.NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C7F RID: 3199 RVA: 0x0004F4FC File Offset: 0x0004D6FC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 573397, XrefRangeEnd = 573398, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsDefaultChoice()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SimpleAIChoice.NativeMethodInfoPtr_IsDefaultChoice_Public_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000C80 RID: 3200 RVA: 0x00006655 File Offset: 0x00004855
		public SimpleAIChoice(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C81 RID: 3201 RVA: 0x0004F538 File Offset: 0x0004D738
		// (set) Token: 0x06000C82 RID: 3202 RVA: 0x0000665E File Offset: 0x0000485E
		public unsafe int rank
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleAIChoice.NativeFieldInfoPtr_rank);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleAIChoice.NativeFieldInfoPtr_rank)) = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C83 RID: 3203 RVA: 0x0004F560 File Offset: 0x0004D760
		// (set) Token: 0x06000C84 RID: 3204 RVA: 0x00006679 File Offset: 0x00004879
		public unsafe EntityID target
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleAIChoice.NativeFieldInfoPtr_target);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SimpleAIChoice.NativeFieldInfoPtr_target), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000895 RID: 2197
		private static readonly IntPtr NativeFieldInfoPtr_rank;

		// Token: 0x04000896 RID: 2198
		private static readonly IntPtr NativeFieldInfoPtr_target;

		// Token: 0x04000897 RID: 2199
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_EntityID_Int32_0;

		// Token: 0x04000898 RID: 2200
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultChoice_Public_Boolean_0;
	}
}
