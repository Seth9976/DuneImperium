using System;
using Canis.utils.ids;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Networking.selection.messages
{
	// Token: 0x02000080 RID: 128
	public class IntChoiceRequired : SelectionMessage
	{
		// Token: 0x06000443 RID: 1091 RVA: 0x000114D0 File Offset: 0x0000F6D0
		// Note: this type is marked as 'beforefieldinit'.
		static IntChoiceRequired()
		{
			Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr = IL2CPP.GetIl2CppClass("Networking.dll", "Networking.selection.messages", "IntChoiceRequired");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr);
			IntChoiceRequired.NativeFieldInfoPtr_amount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, "amount");
			IntChoiceRequired.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, "min");
			IntChoiceRequired.NativeFieldInfoPtr_SourceEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, "SourceEntity");
			IntChoiceRequired.NativeFieldInfoPtr_Kind = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, "Kind");
			IntChoiceRequired.NativeFieldInfoPtr_forced = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, "forced");
			IntChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, 100663572);
			IntChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr, 100663573);
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x0001158C File Offset: 0x0000F78C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1194532, XrefRangeEnd = 1194540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IntChoiceRequired.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x000115D0 File Offset: 0x0000F7D0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1194541, RefRangeEnd = 1194542, XrefRangeStart = 1194540, XrefRangeEnd = 1194541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntChoiceRequired()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntChoiceRequired>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntChoiceRequired.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00004A07 File Offset: 0x00002C07
		public IntChoiceRequired(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0001160C File Offset: 0x0000F80C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00004A10 File Offset: 0x00002C10
		public unsafe int amount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_amount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_amount)) = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00011634 File Offset: 0x0000F834
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x00004A2B File Offset: 0x00002C2B
		public unsafe int min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0001165C File Offset: 0x0000F85C
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00004A46 File Offset: 0x00002C46
		public unsafe EntityID SourceEntity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_SourceEntity);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<EntityID>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_SourceEntity), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x0001168C File Offset: 0x0000F88C
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00004A65 File Offset: 0x00002C65
		public unsafe string Kind
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_Kind);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_Kind), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000116B4 File Offset: 0x0000F8B4
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00004A84 File Offset: 0x00002C84
		public unsafe bool forced
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_forced);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntChoiceRequired.NativeFieldInfoPtr_forced)) = value;
			}
		}

		// Token: 0x04000252 RID: 594
		private static readonly IntPtr NativeFieldInfoPtr_amount;

		// Token: 0x04000253 RID: 595
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x04000254 RID: 596
		private static readonly IntPtr NativeFieldInfoPtr_SourceEntity;

		// Token: 0x04000255 RID: 597
		private static readonly IntPtr NativeFieldInfoPtr_Kind;

		// Token: 0x04000256 RID: 598
		private static readonly IntPtr NativeFieldInfoPtr_forced;

		// Token: 0x04000257 RID: 599
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000258 RID: 600
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
