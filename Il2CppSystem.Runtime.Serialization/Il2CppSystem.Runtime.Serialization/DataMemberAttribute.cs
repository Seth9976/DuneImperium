using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Il2CppSystem.Runtime.Serialization
{
	// Token: 0x02000003 RID: 3
	public sealed class DataMemberAttribute : Attribute
	{
		// Token: 0x06000006 RID: 6 RVA: 0x00002200 File Offset: 0x00000400
		// Note: this type is marked as 'beforefieldinit'.
		static DataMemberAttribute()
		{
			Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Runtime.Serialization.dll", "System.Runtime.Serialization", "DataMemberAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr);
			DataMemberAttribute.NativeFieldInfoPtr_name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, "name");
			DataMemberAttribute.NativeFieldInfoPtr_order = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, "order");
			DataMemberAttribute.NativeFieldInfoPtr_isRequired = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, "isRequired");
			DataMemberAttribute.NativeFieldInfoPtr_emitDefaultValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, "emitDefaultValue");
			DataMemberAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, 100663298);
			DataMemberAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, 100663299);
			DataMemberAttribute.NativeMethodInfoPtr_get_IsRequired_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, 100663300);
			DataMemberAttribute.NativeMethodInfoPtr_get_EmitDefaultValue_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DataMemberAttribute>.NativeClassPtr, 100663301);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022D0 File Offset: 0x000004D0
		public unsafe string Name
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataMemberAttribute.NativeMethodInfoPtr_get_Name_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002308 File Offset: 0x00000508
		public unsafe int Order
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataMemberAttribute.NativeMethodInfoPtr_get_Order_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002344 File Offset: 0x00000544
		public unsafe bool IsRequired
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataMemberAttribute.NativeMethodInfoPtr_get_IsRequired_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002380 File Offset: 0x00000580
		public unsafe bool EmitDefaultValue
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DataMemberAttribute.NativeMethodInfoPtr_get_EmitDefaultValue_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002074 File Offset: 0x00000274
		public DataMemberAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000023BC File Offset: 0x000005BC
		// (set) Token: 0x0600000D RID: 13 RVA: 0x0000207D File Offset: 0x0000027D
		public unsafe string name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000E RID: 14 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x0600000F RID: 15 RVA: 0x0000209C File Offset: 0x0000029C
		public unsafe int order
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_order);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_order)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000240C File Offset: 0x0000060C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000020B7 File Offset: 0x000002B7
		public unsafe bool isRequired
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_isRequired);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_isRequired)) = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002434 File Offset: 0x00000634
		// (set) Token: 0x06000013 RID: 19 RVA: 0x000020D2 File Offset: 0x000002D2
		public unsafe bool emitDefaultValue
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_emitDefaultValue);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DataMemberAttribute.NativeFieldInfoPtr_emitDefaultValue)) = value;
			}
		}

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeFieldInfoPtr_name;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeFieldInfoPtr_order;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeFieldInfoPtr_isRequired;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeFieldInfoPtr_emitDefaultValue;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_get_String_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_Order_Public_get_Int32_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_IsRequired_Public_get_Boolean_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_EmitDefaultValue_Public_get_Boolean_0;
	}
}
