using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using JsonFx.CodeGen;

namespace JsonFx.Serialization.Resolvers
{
	// Token: 0x02000017 RID: 23
	public sealed class MemberMap : Object
	{
		// Token: 0x060000FC RID: 252 RVA: 0x0000786C File Offset: 0x00005A6C
		// Note: this type is marked as 'beforefieldinit'.
		static MemberMap()
		{
			Il2CppClassPointerStore<MemberMap>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.Resolvers", "MemberMap");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MemberMap>.NativeClassPtr);
			MemberMap.NativeFieldInfoPtr_MemberInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "MemberInfo");
			MemberMap.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "Name");
			MemberMap.NativeFieldInfoPtr_DataName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "DataName");
			MemberMap.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "Type");
			MemberMap.NativeFieldInfoPtr_Getter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "Getter");
			MemberMap.NativeFieldInfoPtr_Setter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "Setter");
			MemberMap.NativeFieldInfoPtr_IsIgnored = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, "IsIgnored");
			MemberMap.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_String_ValueIgnoredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, 100663414);
			MemberMap.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_String_ValueIgnoredDelegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MemberMap>.NativeClassPtr, 100663415);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00007950 File Offset: 0x00005B50
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1190629, RefRangeEnd = 1190630, XrefRangeStart = 1190611, XrefRangeEnd = 1190629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberMap(PropertyInfo propertyInfo, string dataName, ValueIgnoredDelegate isIgnored)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dataName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isIgnored);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberMap.NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_String_ValueIgnoredDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000079C0 File Offset: 0x00005BC0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 1190648, RefRangeEnd = 1190650, XrefRangeStart = 1190630, XrefRangeEnd = 1190648, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MemberMap(FieldInfo fieldInfo, string dataName, ValueIgnoredDelegate isIgnored)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MemberMap>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(fieldInfo);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(dataName);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(isIgnored);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MemberMap.NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_String_ValueIgnoredDelegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000025A3 File Offset: 0x000007A3
		public MemberMap(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000100 RID: 256 RVA: 0x00007A30 File Offset: 0x00005C30
		// (set) Token: 0x06000101 RID: 257 RVA: 0x000025AC File Offset: 0x000007AC
		public unsafe MemberInfo MemberInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_MemberInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MemberInfo>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_MemberInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000102 RID: 258 RVA: 0x00007A60 File Offset: 0x00005C60
		// (set) Token: 0x06000103 RID: 259 RVA: 0x000025CB File Offset: 0x000007CB
		public unsafe string Name
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Name);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Name), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000104 RID: 260 RVA: 0x00007A88 File Offset: 0x00005C88
		// (set) Token: 0x06000105 RID: 261 RVA: 0x000025EA File Offset: 0x000007EA
		public unsafe string DataName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_DataName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_DataName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000106 RID: 262 RVA: 0x00007AB0 File Offset: 0x00005CB0
		// (set) Token: 0x06000107 RID: 263 RVA: 0x00002609 File Offset: 0x00000809
		public unsafe Type Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00007AE0 File Offset: 0x00005CE0
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00002628 File Offset: 0x00000828
		public unsafe GetterDelegate Getter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Getter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<GetterDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Getter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00007B10 File Offset: 0x00005D10
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00002647 File Offset: 0x00000847
		public unsafe SetterDelegate Setter
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Setter);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SetterDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_Setter), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00007B40 File Offset: 0x00005D40
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00002666 File Offset: 0x00000866
		public unsafe ValueIgnoredDelegate IsIgnored
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_IsIgnored);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ValueIgnoredDelegate>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MemberMap.NativeFieldInfoPtr_IsIgnored), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000A9 RID: 169
		private static readonly IntPtr NativeFieldInfoPtr_MemberInfo;

		// Token: 0x040000AA RID: 170
		private static readonly IntPtr NativeFieldInfoPtr_Name;

		// Token: 0x040000AB RID: 171
		private static readonly IntPtr NativeFieldInfoPtr_DataName;

		// Token: 0x040000AC RID: 172
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x040000AD RID: 173
		private static readonly IntPtr NativeFieldInfoPtr_Getter;

		// Token: 0x040000AE RID: 174
		private static readonly IntPtr NativeFieldInfoPtr_Setter;

		// Token: 0x040000AF RID: 175
		private static readonly IntPtr NativeFieldInfoPtr_IsIgnored;

		// Token: 0x040000B0 RID: 176
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_PropertyInfo_String_ValueIgnoredDelegate_0;

		// Token: 0x040000B1 RID: 177
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_FieldInfo_String_ValueIgnoredDelegate_0;
	}
}
