using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Il2CppMono.Security.X509
{
	// Token: 0x02000014 RID: 20
	public class X520 : Object
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00002A44 File Offset: 0x00000C44
		// Note: this type is marked as 'beforefieldinit'.
		static X520()
		{
			Il2CppClassPointerStore<X520>.NativeClassPtr = IL2CPP.GetIl2CppClass("Mono.Security.dll", "Mono.Security.X509", "X520");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520>.NativeClassPtr);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00002A69 File Offset: 0x00000C69
		public X520(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0200004C RID: 76
		public class AttributeTypeAndValue : Object
		{
			// Token: 0x060004AE RID: 1198 RVA: 0x00015234 File Offset: 0x00013434
			// Note: this type is marked as 'beforefieldinit'.
			static AttributeTypeAndValue()
			{
				Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "AttributeTypeAndValue");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr);
				X520.AttributeTypeAndValue.NativeFieldInfoPtr_oid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, "oid");
				X520.AttributeTypeAndValue.NativeFieldInfoPtr_attrValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, "attrValue");
				X520.AttributeTypeAndValue.NativeFieldInfoPtr_upperBound = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, "upperBound");
				X520.AttributeTypeAndValue.NativeFieldInfoPtr_encoding = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, "encoding");
				X520.AttributeTypeAndValue.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663528);
				X520.AttributeTypeAndValue.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663529);
				X520.AttributeTypeAndValue.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663530);
				X520.AttributeTypeAndValue.NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663531);
				X520.AttributeTypeAndValue.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663532);
				X520.AttributeTypeAndValue.NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr, 100663533);
			}

			// Token: 0x060004AF RID: 1199 RVA: 0x00015328 File Offset: 0x00013528
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148446, XrefRangeEnd = 1148448, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeTypeAndValue(string oid, int upperBound)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperBound;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004B0 RID: 1200 RVA: 0x00015384 File Offset: 0x00013584
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148448, XrefRangeEnd = 1148450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttributeTypeAndValue(string oid, int upperBound, byte encoding)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.AttributeTypeAndValue>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref upperBound;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref encoding;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x1700019F RID: 415
			// (set) Token: 0x060004B1 RID: 1201 RVA: 0x000153EC File Offset: 0x000135EC
			public unsafe string Value
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148450, XrefRangeEnd = 1148461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = IL2CPP.ManagedStringToIl2Cpp(value);
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr_set_Value_Public_set_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x060004B2 RID: 1202 RVA: 0x00015430 File Offset: 0x00013630
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 1148498, RefRangeEnd = 1148500, XrefRangeStart = 1148461, XrefRangeEnd = 1148498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ASN1 GetASN1(byte encoding)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref encoding;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
				}
			}

			// Token: 0x060004B3 RID: 1203 RVA: 0x0001547C File Offset: 0x0001367C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148500, XrefRangeEnd = 1148501, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ASN1 GetASN1()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr_GetASN1_Internal_ASN1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ASN1>(intPtr3) : null;
			}

			// Token: 0x060004B4 RID: 1204 RVA: 0x000154BC File Offset: 0x000136BC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148501, XrefRangeEnd = 1148503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe byte SelectBestEncoding()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.AttributeTypeAndValue.NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x060004B5 RID: 1205 RVA: 0x00003FE8 File Offset: 0x000021E8
			public AttributeTypeAndValue(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700019B RID: 411
			// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000154F8 File Offset: 0x000136F8
			// (set) Token: 0x060004B7 RID: 1207 RVA: 0x00003FF1 File Offset: 0x000021F1
			public unsafe string oid
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_oid);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_oid), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700019C RID: 412
			// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00015520 File Offset: 0x00013720
			// (set) Token: 0x060004B9 RID: 1209 RVA: 0x00004010 File Offset: 0x00002210
			public unsafe string attrValue
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_attrValue);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_attrValue), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x1700019D RID: 413
			// (get) Token: 0x060004BA RID: 1210 RVA: 0x00015548 File Offset: 0x00013748
			// (set) Token: 0x060004BB RID: 1211 RVA: 0x0000402F File Offset: 0x0000222F
			public unsafe int upperBound
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_upperBound);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_upperBound)) = value;
				}
			}

			// Token: 0x1700019E RID: 414
			// (get) Token: 0x060004BC RID: 1212 RVA: 0x00015570 File Offset: 0x00013770
			// (set) Token: 0x060004BD RID: 1213 RVA: 0x0000404A File Offset: 0x0000224A
			public unsafe byte encoding
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_encoding);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(X520.AttributeTypeAndValue.NativeFieldInfoPtr_encoding)) = value;
				}
			}

			// Token: 0x04000470 RID: 1136
			private static readonly IntPtr NativeFieldInfoPtr_oid;

			// Token: 0x04000471 RID: 1137
			private static readonly IntPtr NativeFieldInfoPtr_attrValue;

			// Token: 0x04000472 RID: 1138
			private static readonly IntPtr NativeFieldInfoPtr_upperBound;

			// Token: 0x04000473 RID: 1139
			private static readonly IntPtr NativeFieldInfoPtr_encoding;

			// Token: 0x04000474 RID: 1140
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_0;

			// Token: 0x04000475 RID: 1141
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_String_Int32_Byte_0;

			// Token: 0x04000476 RID: 1142
			private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_String_0;

			// Token: 0x04000477 RID: 1143
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_Byte_0;

			// Token: 0x04000478 RID: 1144
			private static readonly IntPtr NativeMethodInfoPtr_GetASN1_Internal_ASN1_0;

			// Token: 0x04000479 RID: 1145
			private static readonly IntPtr NativeMethodInfoPtr_SelectBestEncoding_Private_Byte_0;
		}

		// Token: 0x0200004D RID: 77
		public class CommonName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004BE RID: 1214 RVA: 0x00004065 File Offset: 0x00002265
			// Note: this type is marked as 'beforefieldinit'.
			static CommonName()
			{
				Il2CppClassPointerStore<X520.CommonName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "CommonName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.CommonName>.NativeClassPtr);
				X520.CommonName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.CommonName>.NativeClassPtr, 100663534);
			}

			// Token: 0x060004BF RID: 1215 RVA: 0x00015598 File Offset: 0x00013798
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148503, XrefRangeEnd = 1148507, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CommonName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.CommonName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.CommonName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C0 RID: 1216 RVA: 0x00004099 File Offset: 0x00002299
			public CommonName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047A RID: 1146
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200004E RID: 78
		public class SerialNumber : X520.AttributeTypeAndValue
		{
			// Token: 0x060004C1 RID: 1217 RVA: 0x000040A2 File Offset: 0x000022A2
			// Note: this type is marked as 'beforefieldinit'.
			static SerialNumber()
			{
				Il2CppClassPointerStore<X520.SerialNumber>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "SerialNumber");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.SerialNumber>.NativeClassPtr);
				X520.SerialNumber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.SerialNumber>.NativeClassPtr, 100663535);
			}

			// Token: 0x060004C2 RID: 1218 RVA: 0x000155D4 File Offset: 0x000137D4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148507, XrefRangeEnd = 1148511, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SerialNumber()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.SerialNumber>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.SerialNumber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C3 RID: 1219 RVA: 0x000040D6 File Offset: 0x000022D6
			public SerialNumber(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047B RID: 1147
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200004F RID: 79
		public class LocalityName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004C4 RID: 1220 RVA: 0x000040DF File Offset: 0x000022DF
			// Note: this type is marked as 'beforefieldinit'.
			static LocalityName()
			{
				Il2CppClassPointerStore<X520.LocalityName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "LocalityName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.LocalityName>.NativeClassPtr);
				X520.LocalityName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.LocalityName>.NativeClassPtr, 100663536);
			}

			// Token: 0x060004C5 RID: 1221 RVA: 0x00015610 File Offset: 0x00013810
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148511, XrefRangeEnd = 1148515, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe LocalityName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.LocalityName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.LocalityName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C6 RID: 1222 RVA: 0x00004113 File Offset: 0x00002313
			public LocalityName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047C RID: 1148
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000050 RID: 80
		public class StateOrProvinceName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004C7 RID: 1223 RVA: 0x0000411C File Offset: 0x0000231C
			// Note: this type is marked as 'beforefieldinit'.
			static StateOrProvinceName()
			{
				Il2CppClassPointerStore<X520.StateOrProvinceName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "StateOrProvinceName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.StateOrProvinceName>.NativeClassPtr);
				X520.StateOrProvinceName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.StateOrProvinceName>.NativeClassPtr, 100663537);
			}

			// Token: 0x060004C8 RID: 1224 RVA: 0x0001564C File Offset: 0x0001384C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148515, XrefRangeEnd = 1148519, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StateOrProvinceName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.StateOrProvinceName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.StateOrProvinceName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004C9 RID: 1225 RVA: 0x00004150 File Offset: 0x00002350
			public StateOrProvinceName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047D RID: 1149
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000051 RID: 81
		public class OrganizationName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004CA RID: 1226 RVA: 0x00004159 File Offset: 0x00002359
			// Note: this type is marked as 'beforefieldinit'.
			static OrganizationName()
			{
				Il2CppClassPointerStore<X520.OrganizationName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "OrganizationName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.OrganizationName>.NativeClassPtr);
				X520.OrganizationName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.OrganizationName>.NativeClassPtr, 100663538);
			}

			// Token: 0x060004CB RID: 1227 RVA: 0x00015688 File Offset: 0x00013888
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148519, XrefRangeEnd = 1148523, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrganizationName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.OrganizationName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.OrganizationName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004CC RID: 1228 RVA: 0x0000418D File Offset: 0x0000238D
			public OrganizationName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047E RID: 1150
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000052 RID: 82
		public class OrganizationalUnitName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004CD RID: 1229 RVA: 0x00004196 File Offset: 0x00002396
			// Note: this type is marked as 'beforefieldinit'.
			static OrganizationalUnitName()
			{
				Il2CppClassPointerStore<X520.OrganizationalUnitName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "OrganizationalUnitName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.OrganizationalUnitName>.NativeClassPtr);
				X520.OrganizationalUnitName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.OrganizationalUnitName>.NativeClassPtr, 100663539);
			}

			// Token: 0x060004CE RID: 1230 RVA: 0x000156C4 File Offset: 0x000138C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148523, XrefRangeEnd = 1148527, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe OrganizationalUnitName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.OrganizationalUnitName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.OrganizationalUnitName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004CF RID: 1231 RVA: 0x000041CA File Offset: 0x000023CA
			public OrganizationalUnitName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x0400047F RID: 1151
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000053 RID: 83
		public class EmailAddress : X520.AttributeTypeAndValue
		{
			// Token: 0x060004D0 RID: 1232 RVA: 0x000041D3 File Offset: 0x000023D3
			// Note: this type is marked as 'beforefieldinit'.
			static EmailAddress()
			{
				Il2CppClassPointerStore<X520.EmailAddress>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "EmailAddress");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.EmailAddress>.NativeClassPtr);
				X520.EmailAddress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.EmailAddress>.NativeClassPtr, 100663540);
			}

			// Token: 0x060004D1 RID: 1233 RVA: 0x00015700 File Offset: 0x00013900
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148527, XrefRangeEnd = 1148531, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe EmailAddress()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.EmailAddress>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.EmailAddress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D2 RID: 1234 RVA: 0x00004207 File Offset: 0x00002407
			public EmailAddress(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000480 RID: 1152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000054 RID: 84
		public class DomainComponent : X520.AttributeTypeAndValue
		{
			// Token: 0x060004D3 RID: 1235 RVA: 0x00004210 File Offset: 0x00002410
			// Note: this type is marked as 'beforefieldinit'.
			static DomainComponent()
			{
				Il2CppClassPointerStore<X520.DomainComponent>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "DomainComponent");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.DomainComponent>.NativeClassPtr);
				X520.DomainComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.DomainComponent>.NativeClassPtr, 100663541);
			}

			// Token: 0x060004D4 RID: 1236 RVA: 0x0001573C File Offset: 0x0001393C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148531, XrefRangeEnd = 1148535, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DomainComponent()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.DomainComponent>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.DomainComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D5 RID: 1237 RVA: 0x00004244 File Offset: 0x00002444
			public DomainComponent(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000481 RID: 1153
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000055 RID: 85
		public class UserId : X520.AttributeTypeAndValue
		{
			// Token: 0x060004D6 RID: 1238 RVA: 0x0000424D File Offset: 0x0000244D
			// Note: this type is marked as 'beforefieldinit'.
			static UserId()
			{
				Il2CppClassPointerStore<X520.UserId>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "UserId");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.UserId>.NativeClassPtr);
				X520.UserId.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.UserId>.NativeClassPtr, 100663542);
			}

			// Token: 0x060004D7 RID: 1239 RVA: 0x00015778 File Offset: 0x00013978
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148535, XrefRangeEnd = 1148539, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe UserId()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.UserId>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.UserId.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004D8 RID: 1240 RVA: 0x00004281 File Offset: 0x00002481
			public UserId(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000482 RID: 1154
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000056 RID: 86
		public class Oid : X520.AttributeTypeAndValue
		{
			// Token: 0x060004D9 RID: 1241 RVA: 0x0000428A File Offset: 0x0000248A
			// Note: this type is marked as 'beforefieldinit'.
			static Oid()
			{
				Il2CppClassPointerStore<X520.Oid>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Oid");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.Oid>.NativeClassPtr);
				X520.Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.Oid>.NativeClassPtr, 100663543);
			}

			// Token: 0x060004DA RID: 1242 RVA: 0x000157B4 File Offset: 0x000139B4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148539, XrefRangeEnd = 1148541, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Oid(string oid)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.Oid>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(oid);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.Oid.NativeMethodInfoPtr__ctor_Public_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060004DB RID: 1243 RVA: 0x000042BE File Offset: 0x000024BE
			public Oid(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000483 RID: 1155
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_0;
		}

		// Token: 0x02000057 RID: 87
		public class Title : X520.AttributeTypeAndValue
		{
			// Token: 0x060004DC RID: 1244 RVA: 0x000042C7 File Offset: 0x000024C7
			// Note: this type is marked as 'beforefieldinit'.
			static Title()
			{
				Il2CppClassPointerStore<X520.Title>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Title");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.Title>.NativeClassPtr);
				X520.Title.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.Title>.NativeClassPtr, 100663544);
			}

			// Token: 0x060004DD RID: 1245 RVA: 0x00015800 File Offset: 0x00013A00
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148541, XrefRangeEnd = 1148545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Title()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.Title>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.Title.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004DE RID: 1246 RVA: 0x000042FB File Offset: 0x000024FB
			public Title(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000484 RID: 1156
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000058 RID: 88
		public class CountryName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004DF RID: 1247 RVA: 0x00004304 File Offset: 0x00002504
			// Note: this type is marked as 'beforefieldinit'.
			static CountryName()
			{
				Il2CppClassPointerStore<X520.CountryName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "CountryName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.CountryName>.NativeClassPtr);
				X520.CountryName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.CountryName>.NativeClassPtr, 100663545);
			}

			// Token: 0x060004E0 RID: 1248 RVA: 0x0001583C File Offset: 0x00013A3C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148545, XrefRangeEnd = 1148549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe CountryName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.CountryName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.CountryName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004E1 RID: 1249 RVA: 0x00004338 File Offset: 0x00002538
			public CountryName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000485 RID: 1157
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x02000059 RID: 89
		public class DnQualifier : X520.AttributeTypeAndValue
		{
			// Token: 0x060004E2 RID: 1250 RVA: 0x00004341 File Offset: 0x00002541
			// Note: this type is marked as 'beforefieldinit'.
			static DnQualifier()
			{
				Il2CppClassPointerStore<X520.DnQualifier>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "DnQualifier");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.DnQualifier>.NativeClassPtr);
				X520.DnQualifier.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.DnQualifier>.NativeClassPtr, 100663546);
			}

			// Token: 0x060004E3 RID: 1251 RVA: 0x00015878 File Offset: 0x00013A78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148549, XrefRangeEnd = 1148553, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe DnQualifier()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.DnQualifier>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.DnQualifier.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004E4 RID: 1252 RVA: 0x00004375 File Offset: 0x00002575
			public DnQualifier(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000486 RID: 1158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200005A RID: 90
		public class Surname : X520.AttributeTypeAndValue
		{
			// Token: 0x060004E5 RID: 1253 RVA: 0x0000437E File Offset: 0x0000257E
			// Note: this type is marked as 'beforefieldinit'.
			static Surname()
			{
				Il2CppClassPointerStore<X520.Surname>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Surname");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.Surname>.NativeClassPtr);
				X520.Surname.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.Surname>.NativeClassPtr, 100663547);
			}

			// Token: 0x060004E6 RID: 1254 RVA: 0x000158B4 File Offset: 0x00013AB4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148553, XrefRangeEnd = 1148557, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Surname()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.Surname>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.Surname.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004E7 RID: 1255 RVA: 0x000043B2 File Offset: 0x000025B2
			public Surname(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000487 RID: 1159
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200005B RID: 91
		public class GivenName : X520.AttributeTypeAndValue
		{
			// Token: 0x060004E8 RID: 1256 RVA: 0x000043BB File Offset: 0x000025BB
			// Note: this type is marked as 'beforefieldinit'.
			static GivenName()
			{
				Il2CppClassPointerStore<X520.GivenName>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "GivenName");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.GivenName>.NativeClassPtr);
				X520.GivenName.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.GivenName>.NativeClassPtr, 100663548);
			}

			// Token: 0x060004E9 RID: 1257 RVA: 0x000158F0 File Offset: 0x00013AF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148557, XrefRangeEnd = 1148561, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe GivenName()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.GivenName>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.GivenName.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004EA RID: 1258 RVA: 0x000043EF File Offset: 0x000025EF
			public GivenName(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000488 RID: 1160
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}

		// Token: 0x0200005C RID: 92
		public class Initial : X520.AttributeTypeAndValue
		{
			// Token: 0x060004EB RID: 1259 RVA: 0x000043F8 File Offset: 0x000025F8
			// Note: this type is marked as 'beforefieldinit'.
			static Initial()
			{
				Il2CppClassPointerStore<X520.Initial>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<X520>.NativeClassPtr, "Initial");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<X520.Initial>.NativeClassPtr);
				X520.Initial.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<X520.Initial>.NativeClassPtr, 100663549);
			}

			// Token: 0x060004EC RID: 1260 RVA: 0x0001592C File Offset: 0x00013B2C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1148561, XrefRangeEnd = 1148565, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe Initial()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<X520.Initial>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(X520.Initial.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060004ED RID: 1261 RVA: 0x0000442C File Offset: 0x0000262C
			public Initial(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04000489 RID: 1161
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
