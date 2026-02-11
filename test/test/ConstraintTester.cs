using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace dwd.constraint
{
	// Token: 0x02000006 RID: 6
	public class ConstraintTester : MonoBehaviour
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00002C48 File Offset: 0x00000E48
		// Note: this type is marked as 'beforefieldinit'.
		static ConstraintTester()
		{
			Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr = IL2CPP.GetIl2CppClass("test.dll", "dwd.constraint", "ConstraintTester");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr);
			ConstraintTester.NativeFieldInfoPtr_rulesJson = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr, "rulesJson");
			ConstraintTester.NativeMethodInfoPtr_Start_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr, 100663311);
			ConstraintTester.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr, 100663312);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002CB4 File Offset: 0x00000EB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272748, XrefRangeEnd = 1272843, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTester.NativeMethodInfoPtr_Start_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002CE8 File Offset: 0x00000EE8
		[CallerCount(311)]
		[CachedScanResults(RefRangeStart = 494409, RefRangeEnd = 494720, XrefRangeStart = 494409, XrefRangeEnd = 494720, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConstraintTester()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTester.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000219B File Offset: 0x0000039B
		public ConstraintTester(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000031 RID: 49 RVA: 0x00002D24 File Offset: 0x00000F24
		// (set) Token: 0x06000032 RID: 50 RVA: 0x000021A4 File Offset: 0x000003A4
		public unsafe TextAsset rulesJson
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.NativeFieldInfoPtr_rulesJson);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.NativeFieldInfoPtr_rulesJson), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400001A RID: 26
		private static readonly IntPtr NativeFieldInfoPtr_rulesJson;

		// Token: 0x0400001B RID: 27
		private static readonly IntPtr NativeMethodInfoPtr_Start_Private_Void_0;

		// Token: 0x0400001C RID: 28
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200000C RID: 12
		public enum ConstraintTestColor
		{
			// Token: 0x0400003A RID: 58
			Red,
			// Token: 0x0400003B RID: 59
			Blue,
			// Token: 0x0400003C RID: 60
			Green
		}

		// Token: 0x0200000D RID: 13
		public class ConstraintTestData : global::Il2CppSystem.Object
		{
			// Token: 0x0600004F RID: 79 RVA: 0x000031A0 File Offset: 0x000013A0
			// Note: this type is marked as 'beforefieldinit'.
			static ConstraintTestData()
			{
				Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr, "ConstraintTestData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr);
				ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr, "id");
				ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr, "color");
				ConstraintTester.ConstraintTestData.NativeMethodInfoPtr__ctor_Public_Void_Int32_ConstraintTestColor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr, 100663313);
			}

			// Token: 0x06000050 RID: 80 RVA: 0x00003208 File Offset: 0x00001408
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 313224, RefRangeEnd = 313226, XrefRangeStart = 313224, XrefRangeEnd = 313226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstraintTestData(int id, ConstraintTester.ConstraintTestColor color)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintTester.ConstraintTestData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref id;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref color;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTester.ConstraintTestData.NativeMethodInfoPtr__ctor_Public_Void_Int32_ConstraintTestColor_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000051 RID: 81 RVA: 0x000022A9 File Offset: 0x000004A9
			public ConstraintTestData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000052 RID: 82 RVA: 0x00003260 File Offset: 0x00001460
			// (set) Token: 0x06000053 RID: 83 RVA: 0x000022B2 File Offset: 0x000004B2
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000054 RID: 84 RVA: 0x00003288 File Offset: 0x00001488
			// (set) Token: 0x06000055 RID: 85 RVA: 0x000022CD File Offset: 0x000004CD
			public unsafe ConstraintTester.ConstraintTestColor color
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_color);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintTestData.NativeFieldInfoPtr_color)) = value;
				}
			}

			// Token: 0x0400003D RID: 61
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400003E RID: 62
			private static readonly IntPtr NativeFieldInfoPtr_color;

			// Token: 0x0400003F RID: 63
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_ConstraintTestColor_0;
		}

		// Token: 0x0200000E RID: 14
		public class ConstraintSubjectTestData : IConstraintSubject
		{
			// Token: 0x06000056 RID: 86 RVA: 0x000032B0 File Offset: 0x000014B0
			// Note: this type is marked as 'beforefieldinit'.
			static ConstraintSubjectTestData()
			{
				Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConstraintTester>.NativeClassPtr, "ConstraintSubjectTestData");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr);
				ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_data = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, "data");
				ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_index = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, "index");
				ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr__ctor_Public_Void_ConstraintTestData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, 100663314);
				ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr__ctor_Public_Void_IConstraintSubject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, 100663315);
				ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_GetPropertyValue_Public_Virtual_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, 100663316);
				ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_SetPropertyValue_Public_Virtual_Void_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, 100663317);
				ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_GetDomainForProperty_Public_Virtual_Il2CppStructArray_1_Int32_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr, 100663318);
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00003368 File Offset: 0x00001568
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 412652, RefRangeEnd = 412658, XrefRangeStart = 412652, XrefRangeEnd = 412658, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstraintSubjectTestData(ConstraintTester.ConstraintTestData data, int index)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(data);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr__ctor_Public_Void_ConstraintTestData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06000058 RID: 88 RVA: 0x000033C4 File Offset: 0x000015C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272713, XrefRangeEnd = 1272718, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ConstraintSubjectTestData(IConstraintSubject other)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConstraintTester.ConstraintSubjectTestData>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(other);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr__ctor_Public_Void_IConstraintSubject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06000059 RID: 89 RVA: 0x00003410 File Offset: 0x00001610
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272718, XrefRangeEnd = 1272734, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int GetPropertyValue(string propertyName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_GetPropertyValue_Public_Virtual_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600005A RID: 90 RVA: 0x00003468 File Offset: 0x00001668
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272734, XrefRangeEnd = 1272740, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void SetPropertyValue(string propertyName, int newValue)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newValue;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_SetPropertyValue_Public_Virtual_Void_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600005B RID: 91 RVA: 0x000034C4 File Offset: 0x000016C4
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272740, XrefRangeEnd = 1272748, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Il2CppStructArray<int> GetDomainForProperty(string propertyName)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(propertyName);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ConstraintTester.ConstraintSubjectTestData.NativeMethodInfoPtr_GetDomainForProperty_Public_Virtual_Il2CppStructArray_1_Int32_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<int>>(intPtr3) : null;
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x000022E8 File Offset: 0x000004E8
			public ConstraintSubjectTestData(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x0600005D RID: 93 RVA: 0x00003520 File Offset: 0x00001720
			// (set) Token: 0x0600005E RID: 94 RVA: 0x000022F1 File Offset: 0x000004F1
			public unsafe ConstraintTester.ConstraintTestData data
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_data);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ConstraintTester.ConstraintTestData>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_data), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x0600005F RID: 95 RVA: 0x00003550 File Offset: 0x00001750
			// (set) Token: 0x06000060 RID: 96 RVA: 0x00002310 File Offset: 0x00000510
			public unsafe int index
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_index);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConstraintTester.ConstraintSubjectTestData.NativeFieldInfoPtr_index)) = value;
				}
			}

			// Token: 0x04000040 RID: 64
			private static readonly IntPtr NativeFieldInfoPtr_data;

			// Token: 0x04000041 RID: 65
			private static readonly IntPtr NativeFieldInfoPtr_index;

			// Token: 0x04000042 RID: 66
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_ConstraintTestData_Int32_0;

			// Token: 0x04000043 RID: 67
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IConstraintSubject_0;

			// Token: 0x04000044 RID: 68
			private static readonly IntPtr NativeMethodInfoPtr_GetPropertyValue_Public_Virtual_Int32_String_0;

			// Token: 0x04000045 RID: 69
			private static readonly IntPtr NativeMethodInfoPtr_SetPropertyValue_Public_Virtual_Void_String_Int32_0;

			// Token: 0x04000046 RID: 70
			private static readonly IntPtr NativeMethodInfoPtr_GetDomainForProperty_Public_Virtual_Il2CppStructArray_1_Int32_String_0;
		}
	}
}
