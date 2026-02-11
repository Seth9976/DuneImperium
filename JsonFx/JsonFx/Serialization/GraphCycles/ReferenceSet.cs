using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace JsonFx.Serialization.GraphCycles
{
	// Token: 0x0200001E RID: 30
	public class ReferenceSet : Object
	{
		// Token: 0x06000150 RID: 336 RVA: 0x000089D0 File Offset: 0x00006BD0
		// Note: this type is marked as 'beforefieldinit'.
		static ReferenceSet()
		{
			Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr = IL2CPP.GetIl2CppClass("JsonFx.dll", "JsonFx.Serialization.GraphCycles", "ReferenceSet");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr);
			ReferenceSet.NativeFieldInfoPtr_EmptyArray = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, "EmptyArray");
			ReferenceSet.NativeFieldInfoPtr_InitialSize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, "InitialSize");
			ReferenceSet.NativeFieldInfoPtr_GrowthFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, "GrowthFactor");
			ReferenceSet.NativeFieldInfoPtr_array = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, "array");
			ReferenceSet.NativeFieldInfoPtr_size = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, "size");
			ReferenceSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, 100663443);
			ReferenceSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, 100663444);
			ReferenceSet.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr, 100663445);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00008AA0 File Offset: 0x00006CA0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191144, XrefRangeEnd = 1191149, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool Add(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceSet.NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00008AF0 File Offset: 0x00006CF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191149, XrefRangeEnd = 1191152, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Remove(Object item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(item);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceSet.NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00008B34 File Offset: 0x00006D34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1191152, XrefRangeEnd = 1191158, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ReferenceSet()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReferenceSet>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ReferenceSet.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002889 File Offset: 0x00000A89
		public ReferenceSet(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000155 RID: 341 RVA: 0x00008B70 File Offset: 0x00006D70
		// (set) Token: 0x06000156 RID: 342 RVA: 0x00002892 File Offset: 0x00000A92
		public unsafe static Il2CppReferenceArray<Object> EmptyArray
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(ReferenceSet.NativeFieldInfoPtr_EmptyArray, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReferenceSet.NativeFieldInfoPtr_EmptyArray, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000157 RID: 343 RVA: 0x00008B98 File Offset: 0x00006D98
		// (set) Token: 0x06000158 RID: 344 RVA: 0x000028A4 File Offset: 0x00000AA4
		public unsafe static int InitialSize
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReferenceSet.NativeFieldInfoPtr_InitialSize, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReferenceSet.NativeFieldInfoPtr_InitialSize, (void*)(&value));
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000159 RID: 345 RVA: 0x00008BB4 File Offset: 0x00006DB4
		// (set) Token: 0x0600015A RID: 346 RVA: 0x000028B2 File Offset: 0x00000AB2
		public unsafe static int GrowthFactor
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(ReferenceSet.NativeFieldInfoPtr_GrowthFactor, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(ReferenceSet.NativeFieldInfoPtr_GrowthFactor, (void*)(&value));
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015B RID: 347 RVA: 0x00008BD0 File Offset: 0x00006DD0
		// (set) Token: 0x0600015C RID: 348 RVA: 0x000028C0 File Offset: 0x00000AC0
		public unsafe Il2CppReferenceArray<Object> array
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceSet.NativeFieldInfoPtr_array);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceSet.NativeFieldInfoPtr_array), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015D RID: 349 RVA: 0x00008C00 File Offset: 0x00006E00
		// (set) Token: 0x0600015E RID: 350 RVA: 0x000028DF File Offset: 0x00000ADF
		public unsafe int size
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceSet.NativeFieldInfoPtr_size);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ReferenceSet.NativeFieldInfoPtr_size)) = value;
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly IntPtr NativeFieldInfoPtr_EmptyArray;

		// Token: 0x040000DF RID: 223
		private static readonly IntPtr NativeFieldInfoPtr_InitialSize;

		// Token: 0x040000E0 RID: 224
		private static readonly IntPtr NativeFieldInfoPtr_GrowthFactor;

		// Token: 0x040000E1 RID: 225
		private static readonly IntPtr NativeFieldInfoPtr_array;

		// Token: 0x040000E2 RID: 226
		private static readonly IntPtr NativeFieldInfoPtr_size;

		// Token: 0x040000E3 RID: 227
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Virtual_Final_New_Boolean_Object_0;

		// Token: 0x040000E4 RID: 228
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Virtual_Final_New_Void_Object_0;

		// Token: 0x040000E5 RID: 229
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
