using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Text.RegularExpressions
{
	// Token: 0x0200007B RID: 123
	public sealed class ExclusiveReference : Object
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x0003A99C File Offset: 0x00038B9C
		// Note: this type is marked as 'beforefieldinit'.
		static ExclusiveReference()
		{
			Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.dll", "System.Text.RegularExpressions", "ExclusiveReference");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr);
			ExclusiveReference.NativeFieldInfoPtr__ref = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_ref");
			ExclusiveReference.NativeFieldInfoPtr__obj = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_obj");
			ExclusiveReference.NativeFieldInfoPtr__locked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, "_locked");
			ExclusiveReference.NativeMethodInfoPtr_Get_Public_RegexRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664582);
			ExclusiveReference.NativeMethodInfoPtr_Release_Public_Void_RegexRunner_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664583);
			ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr, 100664584);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0003AA44 File Offset: 0x00038C44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437975, XrefRangeEnd = 437977, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RegexRunner Get()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Get_Public_RegexRunner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr3) : null;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0003AA84 File Offset: 0x00038C84
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 437977, XrefRangeEnd = 437981, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release(RegexRunner obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr_Release_Public_Void_RegexRunner_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0003AAC8 File Offset: 0x00038CC8
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ExclusiveReference()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ExclusiveReference>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ExclusiveReference.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x00004812 File Offset: 0x00002A12
		public ExclusiveReference(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x0003AB04 File Offset: 0x00038D04
		// (set) Token: 0x060007C9 RID: 1993 RVA: 0x0000481B File Offset: 0x00002A1B
		public unsafe RegexRunner _ref
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__ref), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x0003AB34 File Offset: 0x00038D34
		// (set) Token: 0x060007CB RID: 1995 RVA: 0x0000483A File Offset: 0x00002A3A
		public unsafe RegexRunner _obj
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<RegexRunner>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__obj), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x0003AB64 File Offset: 0x00038D64
		// (set) Token: 0x060007CD RID: 1997 RVA: 0x00004859 File Offset: 0x00002A59
		public unsafe int _locked
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ExclusiveReference.NativeFieldInfoPtr__locked)) = value;
			}
		}

		// Token: 0x04000684 RID: 1668
		private static readonly IntPtr NativeFieldInfoPtr__ref;

		// Token: 0x04000685 RID: 1669
		private static readonly IntPtr NativeFieldInfoPtr__obj;

		// Token: 0x04000686 RID: 1670
		private static readonly IntPtr NativeFieldInfoPtr__locked;

		// Token: 0x04000687 RID: 1671
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_RegexRunner_0;

		// Token: 0x04000688 RID: 1672
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_RegexRunner_0;

		// Token: 0x04000689 RID: 1673
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
