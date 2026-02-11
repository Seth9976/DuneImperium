using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Canis.json
{
	// Token: 0x02000010 RID: 16
	public class SerializedLikeAttribute : Attribute
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00004004 File Offset: 0x00002204
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedLikeAttribute()
		{
			Il2CppClassPointerStore<SerializedLikeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("DwdJson.dll", "Canis.json", "SerializedLikeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedLikeAttribute>.NativeClassPtr);
			SerializedLikeAttribute.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedLikeAttribute>.NativeClassPtr, "Type");
			SerializedLikeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedLikeAttribute>.NativeClassPtr, 100663344);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000405C File Offset: 0x0000225C
		[CallerCount(96)]
		[CachedScanResults(RefRangeStart = 230, RefRangeEnd = 326, XrefRangeStart = 230, XrefRangeEnd = 326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedLikeAttribute(Type type)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedLikeAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedLikeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00002358 File Offset: 0x00000558
		public SerializedLikeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000040A8 File Offset: 0x000022A8
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002361 File Offset: 0x00000561
		public unsafe Type Type
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedLikeAttribute.NativeFieldInfoPtr_Type);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedLikeAttribute.NativeFieldInfoPtr_Type), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400003D RID: 61
		private static readonly IntPtr NativeFieldInfoPtr_Type;

		// Token: 0x0400003E RID: 62
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Type_0;
	}
}
