using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.ComponentModel
{
	// Token: 0x020000F1 RID: 241
	public sealed class ReadOnlyAttribute : Attribute
	{
		// Token: 0x06000F96 RID: 3990 RVA: 0x00056BB4 File Offset: 0x00054DB4
		// Note: this type is marked as 'beforefieldinit'.
		static ReadOnlyAttribute()
		{
			Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.ComponentModel", "ReadOnlyAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr);
			ReadOnlyAttribute.NativeFieldInfoPtr_Yes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, "Yes");
			ReadOnlyAttribute.NativeFieldInfoPtr_No = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, "No");
			ReadOnlyAttribute.NativeFieldInfoPtr_Default = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, "Default");
			ReadOnlyAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, "<IsReadOnly>k__BackingField");
			ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100665545);
			ReadOnlyAttribute.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100665546);
			ReadOnlyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100665547);
			ReadOnlyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100665548);
			ReadOnlyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr, 100665549);
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00056C98 File Offset: 0x00054E98
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReadOnlyAttribute(bool isReadOnly)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReadOnlyAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref isReadOnly;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06000F98 RID: 3992 RVA: 0x00056CE0 File Offset: 0x00054EE0
		public unsafe bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00056D1C File Offset: 0x00054F1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456366, XrefRangeEnd = 456373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x00056D6C File Offset: 0x00054F6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00056DA8 File Offset: 0x00054FA8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 456373, XrefRangeEnd = 456377, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool IsDefaultAttribute()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReadOnlyAttribute.NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000079F2 File Offset: 0x00005BF2
		public ReadOnlyAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06000F9D RID: 3997 RVA: 0x00056DE4 File Offset: 0x00054FE4
		// (set) Token: 0x06000F9E RID: 3998 RVA: 0x000079FB File Offset: 0x00005BFB
		public unsafe static ReadOnlyAttribute Yes
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReadOnlyAttribute.NativeFieldInfoPtr_Yes, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadOnlyAttribute.NativeFieldInfoPtr_Yes, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06000F9F RID: 3999 RVA: 0x00056E0C File Offset: 0x0005500C
		// (set) Token: 0x06000FA0 RID: 4000 RVA: 0x00007A0D File Offset: 0x00005C0D
		public unsafe static ReadOnlyAttribute No
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReadOnlyAttribute.NativeFieldInfoPtr_No, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadOnlyAttribute.NativeFieldInfoPtr_No, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06000FA1 RID: 4001 RVA: 0x00056E34 File Offset: 0x00055034
		// (set) Token: 0x06000FA2 RID: 4002 RVA: 0x00007A1F File Offset: 0x00005C1F
		public unsafe static ReadOnlyAttribute Default
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReadOnlyAttribute.NativeFieldInfoPtr_Default, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ReadOnlyAttribute>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReadOnlyAttribute.NativeFieldInfoPtr_Default, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06000FA3 RID: 4003 RVA: 0x00056E5C File Offset: 0x0005505C
		// (set) Token: 0x06000FA4 RID: 4004 RVA: 0x00007A31 File Offset: 0x00005C31
		public unsafe bool _IsReadOnly_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReadOnlyAttribute.NativeFieldInfoPtr__IsReadOnly_k__BackingField)) = value;
			}
		}

		// Token: 0x04000CA5 RID: 3237
		private static readonly IntPtr NativeFieldInfoPtr_Yes;

		// Token: 0x04000CA6 RID: 3238
		private static readonly IntPtr NativeFieldInfoPtr_No;

		// Token: 0x04000CA7 RID: 3239
		private static readonly IntPtr NativeFieldInfoPtr_Default;

		// Token: 0x04000CA8 RID: 3240
		private static readonly IntPtr NativeFieldInfoPtr__IsReadOnly_k__BackingField;

		// Token: 0x04000CA9 RID: 3241
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x04000CAA RID: 3242
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_get_Boolean_0;

		// Token: 0x04000CAB RID: 3243
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04000CAC RID: 3244
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04000CAD RID: 3245
		private static readonly IntPtr NativeMethodInfoPtr_IsDefaultAttribute_Public_Virtual_Boolean_0;
	}
}
