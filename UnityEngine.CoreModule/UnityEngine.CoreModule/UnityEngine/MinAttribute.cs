using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000113 RID: 275
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x0600169D RID: 5789 RVA: 0x0006CE80 File Offset: 0x0006B080
		// Note: this type is marked as 'beforefieldinit'.
		static MinAttribute()
		{
			Il2CppClassPointerStore<MinAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "MinAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr);
			MinAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, "min");
			MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr, 100666432);
		}

		// Token: 0x0600169E RID: 5790 RVA: 0x0006CED8 File Offset: 0x0006B0D8
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 660164, RefRangeEnd = 660172, XrefRangeStart = 660164, XrefRangeEnd = 660172, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe MinAttribute(float min)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<MinAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MinAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x00008EA6 File Offset: 0x000070A6
		public MinAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060016A0 RID: 5792 RVA: 0x0006CF20 File Offset: 0x0006B120
		// (set) Token: 0x060016A1 RID: 5793 RVA: 0x00008EAF File Offset: 0x000070AF
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MinAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x040014BF RID: 5311
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040014C0 RID: 5312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
	}
}
