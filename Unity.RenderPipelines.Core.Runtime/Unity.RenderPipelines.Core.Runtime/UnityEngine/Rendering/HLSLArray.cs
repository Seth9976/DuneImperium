using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x020000B1 RID: 177
	public class HLSLArray : Attribute
	{
		// Token: 0x06000C9A RID: 3226 RVA: 0x0003A7E0 File Offset: 0x000389E0
		// Note: this type is marked as 'beforefieldinit'.
		static HLSLArray()
		{
			Il2CppClassPointerStore<HLSLArray>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.RenderPipelines.Core.Runtime.dll", "UnityEngine.Rendering", "HLSLArray");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr);
			HLSLArray.NativeFieldInfoPtr_arraySize = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, "arraySize");
			HLSLArray.NativeFieldInfoPtr_elementType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, "elementType");
			HLSLArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr, 100665124);
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x0003A84C File Offset: 0x00038A4C
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 971651, RefRangeEnd = 971655, XrefRangeStart = 971649, XrefRangeEnd = 971651, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe HLSLArray(int arraySize, Type elementType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HLSLArray>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref arraySize;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(elementType);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(HLSLArray.NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x000078F0 File Offset: 0x00005AF0
		public HLSLArray(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06000C9D RID: 3229 RVA: 0x0003A8A8 File Offset: 0x00038AA8
		// (set) Token: 0x06000C9E RID: 3230 RVA: 0x000078F9 File Offset: 0x00005AF9
		public unsafe int arraySize
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HLSLArray.NativeFieldInfoPtr_arraySize);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HLSLArray.NativeFieldInfoPtr_arraySize)) = value;
			}
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06000C9F RID: 3231 RVA: 0x0003A8D0 File Offset: 0x00038AD0
		// (set) Token: 0x06000CA0 RID: 3232 RVA: 0x00007914 File Offset: 0x00005B14
		public unsafe Type elementType
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(HLSLArray.NativeFieldInfoPtr_elementType);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(HLSLArray.NativeFieldInfoPtr_elementType), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000971 RID: 2417
		private static readonly IntPtr NativeFieldInfoPtr_arraySize;

		// Token: 0x04000972 RID: 2418
		private static readonly IntPtr NativeFieldInfoPtr_elementType;

		// Token: 0x04000973 RID: 2419
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Type_0;
	}
}
