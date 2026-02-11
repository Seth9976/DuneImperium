using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000112 RID: 274
	public sealed class RangeAttribute : PropertyAttribute
	{
		// Token: 0x06001696 RID: 5782 RVA: 0x0006CD6C File Offset: 0x0006AF6C
		// Note: this type is marked as 'beforefieldinit'.
		static RangeAttribute()
		{
			Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "RangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr);
			RangeAttribute.NativeFieldInfoPtr_min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "min");
			RangeAttribute.NativeFieldInfoPtr_max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, "max");
			RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr, 100666431);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x0006CDD8 File Offset: 0x0006AFD8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660172, XrefRangeEnd = 660173, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RangeAttribute(float min, float max)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref min;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref max;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00008E67 File Offset: 0x00007067
		public RangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001699 RID: 5785 RVA: 0x0006CE30 File Offset: 0x0006B030
		// (set) Token: 0x0600169A RID: 5786 RVA: 0x00008E70 File Offset: 0x00007070
		public unsafe float min
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_min)) = value;
			}
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x0600169B RID: 5787 RVA: 0x0006CE58 File Offset: 0x0006B058
		// (set) Token: 0x0600169C RID: 5788 RVA: 0x00008E8B File Offset: 0x0000708B
		public unsafe float max
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RangeAttribute.NativeFieldInfoPtr_max)) = value;
			}
		}

		// Token: 0x040014BC RID: 5308
		private static readonly IntPtr NativeFieldInfoPtr_min;

		// Token: 0x040014BD RID: 5309
		private static readonly IntPtr NativeFieldInfoPtr_max;

		// Token: 0x040014BE RID: 5310
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
	}
}
