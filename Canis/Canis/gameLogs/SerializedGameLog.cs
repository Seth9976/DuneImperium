using System;
using Canis.attributes;
using Canis.utils.localization;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.gameLogs
{
	// Token: 0x020000AB RID: 171
	[Serializable]
	public class SerializedGameLog : Object
	{
		// Token: 0x06000808 RID: 2056 RVA: 0x00039DA4 File Offset: 0x00037FA4
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedGameLog()
		{
			Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.gameLogs", "SerializedGameLog");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr);
			SerializedGameLog.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, "id");
			SerializedGameLog.NativeFieldInfoPtr_logText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, "logText");
			SerializedGameLog.NativeFieldInfoPtr_parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, "parent");
			SerializedGameLog.NativeFieldInfoPtr_undo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, "undo");
			SerializedGameLog.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, "attributes");
			SerializedGameLog.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, 100664945);
			SerializedGameLog.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr, 100664946);
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00039E60 File Offset: 0x00038060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 559083, XrefRangeEnd = 559090, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedGameLog.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x00039EA4 File Offset: 0x000380A4
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedGameLog()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedGameLog>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedGameLog.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000052AF File Offset: 0x000034AF
		public SerializedGameLog(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00039EE0 File Offset: 0x000380E0
		// (set) Token: 0x0600080D RID: 2061 RVA: 0x000052B8 File Offset: 0x000034B8
		public unsafe int id
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_id);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_id)) = value;
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00039F08 File Offset: 0x00038108
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x000052D3 File Offset: 0x000034D3
		public unsafe LocalizableTextVariables logText
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_logText);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<LocalizableTextVariables>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_logText), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00039F38 File Offset: 0x00038138
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x000052F2 File Offset: 0x000034F2
		public Nullable<int> parent
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_parent);
				return new Nullable<int>(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_parent), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable<int>>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00039F68 File Offset: 0x00038168
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x00005320 File Offset: 0x00003520
		public unsafe bool undo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_undo);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_undo)) = value;
			}
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00039F90 File Offset: 0x00038190
		// (set) Token: 0x06000815 RID: 2069 RVA: 0x0000533B File Offset: 0x0000353B
		public unsafe ReadOnlyAttributes attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttributes>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedGameLog.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400057D RID: 1405
		private static readonly IntPtr NativeFieldInfoPtr_id;

		// Token: 0x0400057E RID: 1406
		private static readonly IntPtr NativeFieldInfoPtr_logText;

		// Token: 0x0400057F RID: 1407
		private static readonly IntPtr NativeFieldInfoPtr_parent;

		// Token: 0x04000580 RID: 1408
		private static readonly IntPtr NativeFieldInfoPtr_undo;

		// Token: 0x04000581 RID: 1409
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000582 RID: 1410
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x04000583 RID: 1411
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
