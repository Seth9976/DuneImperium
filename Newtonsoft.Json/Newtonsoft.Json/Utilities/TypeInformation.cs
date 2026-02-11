using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000049 RID: 73
	public class TypeInformation : Object
	{
		// Token: 0x060006CD RID: 1741 RVA: 0x000323D8 File Offset: 0x000305D8
		// Note: this type is marked as 'beforefieldinit'.
		static TypeInformation()
		{
			Il2CppClassPointerStore<TypeInformation>.NativeClassPtr = IL2CPP.GetIl2CppClass("Newtonsoft.Json.dll", "Newtonsoft.Json.Utilities", "TypeInformation");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr);
			TypeInformation.NativeFieldInfoPtr__Type_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "<Type>k__BackingField");
			TypeInformation.NativeFieldInfoPtr__TypeCode_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, "<TypeCode>k__BackingField");
			TypeInformation.NativeMethodInfoPtr_get_Type_Public_get_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100664627);
			TypeInformation.NativeMethodInfoPtr_get_TypeCode_Public_get_PrimitiveTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100664628);
			TypeInformation.NativeMethodInfoPtr__ctor_Public_Void_Type_PrimitiveTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr, 100664629);
		}

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0003246C File Offset: 0x0003066C
		public unsafe Type Type
		{
			[CallerCount(10)]
			[CachedScanResults(RefRangeStart = 123248, RefRangeEnd = 123258, XrefRangeStart = 123248, XrefRangeEnd = 123258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_Type_Public_get_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x000324AC File Offset: 0x000306AC
		public unsafe PrimitiveTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr_get_TypeCode_Public_get_PrimitiveTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x000324E8 File Offset: 0x000306E8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TypeInformation(Type type, PrimitiveTypeCode typeCode)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TypeInformation>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeCode;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TypeInformation.NativeMethodInfoPtr__ctor_Public_Void_Type_PrimitiveTypeCode_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000041A2 File Offset: 0x000023A2
		public TypeInformation(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00032544 File Offset: 0x00030744
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x000041AB File Offset: 0x000023AB
		public unsafe Type _Type_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr__Type_k__BackingField);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr__Type_k__BackingField), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00032574 File Offset: 0x00030774
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000041CA File Offset: 0x000023CA
		public unsafe PrimitiveTypeCode _TypeCode_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr__TypeCode_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TypeInformation.NativeFieldInfoPtr__TypeCode_k__BackingField)) = value;
			}
		}

		// Token: 0x0400060A RID: 1546
		private static readonly IntPtr NativeFieldInfoPtr__Type_k__BackingField;

		// Token: 0x0400060B RID: 1547
		private static readonly IntPtr NativeFieldInfoPtr__TypeCode_k__BackingField;

		// Token: 0x0400060C RID: 1548
		private static readonly IntPtr NativeMethodInfoPtr_get_Type_Public_get_Type_0;

		// Token: 0x0400060D RID: 1549
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_get_PrimitiveTypeCode_0;

		// Token: 0x0400060E RID: 1550
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_PrimitiveTypeCode_0;
	}
}
