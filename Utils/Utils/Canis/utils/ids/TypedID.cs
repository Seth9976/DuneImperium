using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.utils.ids
{
	// Token: 0x02000022 RID: 34
	[Serializable]
	public class TypedID : Object
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00009A30 File Offset: 0x00007C30
		// Note: this type is marked as 'beforefieldinit'.
		static TypedID()
		{
			Il2CppClassPointerStore<TypedID>.NativeClassPtr = IL2CPP.GetIl2CppClass("Utils.dll", "Canis.utils.ids", "TypedID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypedID>.NativeClassPtr);
			TypedID.NativeFieldInfoPtr__ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedID>.NativeClassPtr, "_ID");
			TypedID.NativeFieldInfoPtr_serializedID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedID>.NativeClassPtr, "serializedID");
			TypedID.NativeFieldInfoPtr_idField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypedID>.NativeClassPtr, "idField");
			TypedID.NativeMethodInfoPtr__ctor_Protected_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663508);
			TypedID.NativeMethodInfoPtr__ctor_Protected_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663509);
			TypedID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663510);
			TypedID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663511);
			TypedID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663512);
			TypedID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663513);
			TypedID.NativeMethodInfoPtr_IdEquals_Public_Boolean_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663514);
			TypedID.NativeMethodInfoPtr_Equals_Protected_Static_Boolean_TypedID_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663515);
			TypedID.NativeMethodInfoPtr_Compare_Protected_Static_Int32_TypedID_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663516);
			TypedID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663517);
			TypedID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TypedID_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663518);
			TypedID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TypedID_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663519);
			TypedID.NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663520);
			TypedID.NativeMethodInfoPtr_op_Explicit_Public_Static_String_TypedID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663521);
			TypedID.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663522);
			TypedID.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypedID>.NativeClassPtr, 100663523);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00009BDC File Offset: 0x00007DDC
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 1180055, RefRangeEnd = 1180063, XrefRangeStart = 1180053, XrefRangeEnd = 1180055, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedID(string id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr__ctor_Protected_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00009C28 File Offset: 0x00007E28
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 629072, RefRangeEnd = 629078, XrefRangeStart = 629072, XrefRangeEnd = 629078, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypedID(Guid id)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypedID>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref id;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr__ctor_Protected_Void_Guid_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00009C70 File Offset: 0x00007E70
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180063, XrefRangeEnd = 1180070, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int CompareTo(TypedID other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TypedID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00009CC0 File Offset: 0x00007EC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180070, XrefRangeEnd = 1180071, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedID.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00009D04 File Offset: 0x00007F04
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180071, XrefRangeEnd = 1180083, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00009D5C File Offset: 0x00007F5C
		[CallerCount(25)]
		[CachedScanResults(RefRangeStart = 1180093, RefRangeEnd = 1180118, XrefRangeStart = 1180083, XrefRangeEnd = 1180093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Equals(TypedID other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypedID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00009DAC File Offset: 0x00007FAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1180119, RefRangeEnd = 1180120, XrefRangeStart = 1180118, XrefRangeEnd = 1180119, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IdEquals(TypedID other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_IdEquals_Public_Boolean_TypedID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00009DFC File Offset: 0x00007FFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180120, XrefRangeEnd = 1180130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool Equals(TypedID id1, TypedID id2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_Equals_Protected_Static_Boolean_TypedID_TypedID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00009E50 File Offset: 0x00008050
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180130, XrefRangeEnd = 1180131, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Compare(TypedID id1, TypedID id2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_Compare_Protected_Static_Int32_TypedID_TypedID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00009EA4 File Offset: 0x000080A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1180131, XrefRangeEnd = 1180132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), TypedID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00009EEC File Offset: 0x000080EC
		[CallerCount(670)]
		[CachedScanResults(RefRangeStart = 1180142, RefRangeEnd = 1180812, XrefRangeStart = 1180132, XrefRangeEnd = 1180142, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(TypedID id1, TypedID id2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TypedID_TypedID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00009F40 File Offset: 0x00008140
		[CallerCount(307)]
		[CachedScanResults(RefRangeStart = 1180822, RefRangeEnd = 1181129, XrefRangeStart = 1180812, XrefRangeEnd = 1180822, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(TypedID id1, TypedID id2)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id1);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(id2);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TypedID_TypedID_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00009F94 File Offset: 0x00008194
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181129, XrefRangeEnd = 1181130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static explicit operator Guid(TypedID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_TypedID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00009FD8 File Offset: 0x000081D8
		[CallerCount(0)]
		public unsafe static explicit operator string(TypedID id)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(id);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_op_Explicit_Public_Static_String_TypedID_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000A014 File Offset: 0x00008214
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181130, XrefRangeEnd = 1181132, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnBeforeSerialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000A048 File Offset: 0x00008248
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1181132, XrefRangeEnd = 1181141, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnAfterDeserialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypedID.NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000025D4 File Offset: 0x000007D4
		public TypedID(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000A07C File Offset: 0x0000827C
		// (set) Token: 0x06000161 RID: 353 RVA: 0x000025DD File Offset: 0x000007DD
		public unsafe Guid _ID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedID.NativeFieldInfoPtr__ID);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedID.NativeFieldInfoPtr__ID)) = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000A0A4 File Offset: 0x000082A4
		// (set) Token: 0x06000163 RID: 355 RVA: 0x000025F8 File Offset: 0x000007F8
		public unsafe string serializedID
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedID.NativeFieldInfoPtr_serializedID);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypedID.NativeFieldInfoPtr_serializedID), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000A0CC File Offset: 0x000082CC
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00002617 File Offset: 0x00000817
		public unsafe static FieldInfo idField
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(TypedID.NativeFieldInfoPtr_idField, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FieldInfo>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(TypedID.NativeFieldInfoPtr_idField, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeFieldInfoPtr__ID;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeFieldInfoPtr_serializedID;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeFieldInfoPtr_idField;

		// Token: 0x040000E6 RID: 230
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_0;

		// Token: 0x040000E7 RID: 231
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_Guid_0;

		// Token: 0x040000E8 RID: 232
		private static readonly IntPtr NativeMethodInfoPtr_CompareTo_Public_Virtual_Final_New_Int32_TypedID_0;

		// Token: 0x040000E9 RID: 233
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;

		// Token: 0x040000EA RID: 234
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040000EB RID: 235
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_TypedID_0;

		// Token: 0x040000EC RID: 236
		private static readonly IntPtr NativeMethodInfoPtr_IdEquals_Public_Boolean_TypedID_0;

		// Token: 0x040000ED RID: 237
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Protected_Static_Boolean_TypedID_TypedID_0;

		// Token: 0x040000EE RID: 238
		private static readonly IntPtr NativeMethodInfoPtr_Compare_Protected_Static_Int32_TypedID_TypedID_0;

		// Token: 0x040000EF RID: 239
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040000F0 RID: 240
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_TypedID_TypedID_0;

		// Token: 0x040000F1 RID: 241
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_TypedID_TypedID_0;

		// Token: 0x040000F2 RID: 242
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_Guid_TypedID_0;

		// Token: 0x040000F3 RID: 243
		private static readonly IntPtr NativeMethodInfoPtr_op_Explicit_Public_Static_String_TypedID_0;

		// Token: 0x040000F4 RID: 244
		private static readonly IntPtr NativeMethodInfoPtr_OnBeforeSerialize_Public_Virtual_Final_New_Void_0;

		// Token: 0x040000F5 RID: 245
		private static readonly IntPtr NativeMethodInfoPtr_OnAfterDeserialize_Public_Virtual_Final_New_Void_0;
	}
}
