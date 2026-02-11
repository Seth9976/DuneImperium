using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x02000112 RID: 274
	public class KeySequence : Object
	{
		// Token: 0x06001889 RID: 6281 RVA: 0x0007EA40 File Offset: 0x0007CC40
		// Note: this type is marked as 'beforefieldinit'.
		static KeySequence()
		{
			Il2CppClassPointerStore<KeySequence>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "KeySequence");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<KeySequence>.NativeClassPtr);
			KeySequence.NativeFieldInfoPtr_ks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "ks");
			KeySequence.NativeFieldInfoPtr_dim = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "dim");
			KeySequence.NativeFieldInfoPtr_hashcode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "hashcode");
			KeySequence.NativeFieldInfoPtr_posline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "posline");
			KeySequence.NativeFieldInfoPtr_poscol = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, "poscol");
			KeySequence.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667099);
			KeySequence.NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667100);
			KeySequence.NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667101);
			KeySequence.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667102);
			KeySequence.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667103);
			KeySequence.NativeMethodInfoPtr_IsQualified_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667104);
			KeySequence.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667105);
			KeySequence.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667106);
			KeySequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<KeySequence>.NativeClassPtr, 100667107);
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x0007EB88 File Offset: 0x0007CD88
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 391996, XrefRangeEnd = 392001, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe KeySequence(int dim, int line, int col)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<KeySequence>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref dim;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref line;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref col;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x0600188B RID: 6283 RVA: 0x0007EBEC File Offset: 0x0007CDEC
		public unsafe int PosLine
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600188C RID: 6284 RVA: 0x0007EC28 File Offset: 0x0007CE28
		public unsafe int PosCol
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170007F7 RID: 2039
		public unsafe Object this[int index]
		{
			[CallerCount(11)]
			[CachedScanResults(RefRangeStart = 312068, RefRangeEnd = 312079, XrefRangeStart = 312068, XrefRangeEnd = 312079, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 392012, RefRangeEnd = 392017, XrefRangeStart = 392001, XrefRangeEnd = 392012, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600188F RID: 6287 RVA: 0x0007ED00 File Offset: 0x0007CF00
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 392018, RefRangeEnd = 392024, XrefRangeStart = 392017, XrefRangeEnd = 392018, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsQualified()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(KeySequence.NativeMethodInfoPtr_IsQualified_Internal_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001890 RID: 6288 RVA: 0x0007ED3C File Offset: 0x0007CF3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392024, XrefRangeEnd = 392046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001891 RID: 6289 RVA: 0x0007ED84 File Offset: 0x0007CF84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392046, XrefRangeEnd = 392051, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object other)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001892 RID: 6290 RVA: 0x0007EDDC File Offset: 0x0007CFDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 392051, XrefRangeEnd = 392063, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override string ToString()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), KeySequence.NativeMethodInfoPtr_ToString_Public_Virtual_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06001893 RID: 6291 RVA: 0x0000A837 File Offset: 0x00008A37
		public KeySequence(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06001894 RID: 6292 RVA: 0x0007EE20 File Offset: 0x0007D020
		// (set) Token: 0x06001895 RID: 6293 RVA: 0x0000A840 File Offset: 0x00008A40
		public unsafe Il2CppReferenceArray<TypedObject> ks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_ks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<TypedObject>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_ks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x06001896 RID: 6294 RVA: 0x0007EE50 File Offset: 0x0007D050
		// (set) Token: 0x06001897 RID: 6295 RVA: 0x0000A85F File Offset: 0x00008A5F
		public unsafe int dim
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_dim);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_dim)) = value;
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001898 RID: 6296 RVA: 0x0007EE78 File Offset: 0x0007D078
		// (set) Token: 0x06001899 RID: 6297 RVA: 0x0000A87A File Offset: 0x00008A7A
		public unsafe int hashcode
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_hashcode);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_hashcode)) = value;
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600189A RID: 6298 RVA: 0x0007EEA0 File Offset: 0x0007D0A0
		// (set) Token: 0x0600189B RID: 6299 RVA: 0x0000A895 File Offset: 0x00008A95
		public unsafe int posline
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_posline);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_posline)) = value;
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x0600189C RID: 6300 RVA: 0x0007EEC8 File Offset: 0x0007D0C8
		// (set) Token: 0x0600189D RID: 6301 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public unsafe int poscol
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_poscol);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(KeySequence.NativeFieldInfoPtr_poscol)) = value;
			}
		}

		// Token: 0x0400132F RID: 4911
		private static readonly IntPtr NativeFieldInfoPtr_ks;

		// Token: 0x04001330 RID: 4912
		private static readonly IntPtr NativeFieldInfoPtr_dim;

		// Token: 0x04001331 RID: 4913
		private static readonly IntPtr NativeFieldInfoPtr_hashcode;

		// Token: 0x04001332 RID: 4914
		private static readonly IntPtr NativeFieldInfoPtr_posline;

		// Token: 0x04001333 RID: 4915
		private static readonly IntPtr NativeFieldInfoPtr_poscol;

		// Token: 0x04001334 RID: 4916
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Int32_Int32_0;

		// Token: 0x04001335 RID: 4917
		private static readonly IntPtr NativeMethodInfoPtr_get_PosLine_Public_get_Int32_0;

		// Token: 0x04001336 RID: 4918
		private static readonly IntPtr NativeMethodInfoPtr_get_PosCol_Public_get_Int32_0;

		// Token: 0x04001337 RID: 4919
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_get_Object_Int32_0;

		// Token: 0x04001338 RID: 4920
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_Object_0;

		// Token: 0x04001339 RID: 4921
		private static readonly IntPtr NativeMethodInfoPtr_IsQualified_Internal_Boolean_0;

		// Token: 0x0400133A RID: 4922
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x0400133B RID: 4923
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400133C RID: 4924
		private static readonly IntPtr NativeMethodInfoPtr_ToString_Public_Virtual_String_0;
	}
}
