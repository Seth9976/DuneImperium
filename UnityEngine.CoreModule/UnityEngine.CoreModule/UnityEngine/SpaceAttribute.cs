using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000110 RID: 272
	public class SpaceAttribute : PropertyAttribute
	{
		// Token: 0x0600168B RID: 5771 RVA: 0x0006CB88 File Offset: 0x0006AD88
		// Note: this type is marked as 'beforefieldinit'.
		static SpaceAttribute()
		{
			Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "SpaceAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr);
			SpaceAttribute.NativeFieldInfoPtr_height = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, "height");
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100666428);
			SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr, 100666429);
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x0006CBF4 File Offset: 0x0006ADF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660162, XrefRangeEnd = 660163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x0006CC30 File Offset: 0x0006AE30
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 660164, RefRangeEnd = 660172, XrefRangeStart = 660163, XrefRangeEnd = 660164, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SpaceAttribute(float height)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SpaceAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref height;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpaceAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600168E RID: 5774 RVA: 0x00008E1B File Offset: 0x0000701B
		public SpaceAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x0600168F RID: 5775 RVA: 0x0006CC78 File Offset: 0x0006AE78
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00008E24 File Offset: 0x00007024
		public unsafe float height
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SpaceAttribute.NativeFieldInfoPtr_height)) = value;
			}
		}

		// Token: 0x040014B7 RID: 5303
		private static readonly IntPtr NativeFieldInfoPtr_height;

		// Token: 0x040014B8 RID: 5304
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040014B9 RID: 5305
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
