using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.CompilerServices
{
	// Token: 0x020003C5 RID: 965
	public sealed class TupleElementNamesAttribute : Attribute
	{
		// Token: 0x0600394E RID: 14670 RVA: 0x001157BC File Offset: 0x001139BC
		// Note: this type is marked as 'beforefieldinit'.
		static TupleElementNamesAttribute()
		{
			Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.CompilerServices", "TupleElementNamesAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr);
			TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, "_transformNames");
			TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr, 100671844);
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x00115814 File Offset: 0x00113A14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1392987, XrefRangeEnd = 1392995, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TupleElementNamesAttribute(Il2CppStringArray transformNames)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TupleElementNamesAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(transformNames);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(TupleElementNamesAttribute.NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003950 RID: 14672 RVA: 0x00015388 File Offset: 0x00013588
		public TupleElementNamesAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x00115860 File Offset: 0x00113A60
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x00015391 File Offset: 0x00013591
		public unsafe Il2CppStringArray _transformNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(TupleElementNamesAttribute.NativeFieldInfoPtr__transformNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002E98 RID: 11928
		private static readonly IntPtr NativeFieldInfoPtr__transformNames;

		// Token: 0x04002E99 RID: 11929
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Il2CppStringArray_0;
	}
}
