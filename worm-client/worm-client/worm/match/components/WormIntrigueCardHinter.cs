using System;
using boardgames.hints;
using boardgames.match.selection;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace worm.match.components
{
	// Token: 0x020001FD RID: 509
	public class WormIntrigueCardHinter : DBGHinter
	{
		// Token: 0x06001682 RID: 5762 RVA: 0x0005C698 File Offset: 0x0005A898
		// Note: this type is marked as 'beforefieldinit'.
		static WormIntrigueCardHinter()
		{
			Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "worm.match.components", "WormIntrigueCardHinter");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr);
			WormIntrigueCardHinter.NativeFieldInfoPtr_selectionResponder = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr, "selectionResponder");
			WormIntrigueCardHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr, 100666429);
			WormIntrigueCardHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr, 100666430);
			WormIntrigueCardHinter.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr, 100666431);
		}

		// Token: 0x06001683 RID: 5763 RVA: 0x0005C718 File Offset: 0x0005A918
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716585, XrefRangeEnd = 716589, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Start()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardHinter.NativeMethodInfoPtr_Start_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x0005C754 File Offset: 0x0005A954
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716589, XrefRangeEnd = 716622, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetHint(string flavor, bool newVal)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(flavor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref newVal;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormIntrigueCardHinter.NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x0005C7B0 File Offset: 0x0005A9B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 716622, XrefRangeEnd = 716623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WormIntrigueCardHinter()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormIntrigueCardHinter>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormIntrigueCardHinter.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x0000D8D2 File Offset: 0x0000BAD2
		public WormIntrigueCardHinter(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001687 RID: 5767 RVA: 0x0005C7EC File Offset: 0x0005A9EC
		// (set) Token: 0x06001688 RID: 5768 RVA: 0x0000D8DB File Offset: 0x0000BADB
		public unsafe DBGSelectionResponder selectionResponder
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardHinter.NativeFieldInfoPtr_selectionResponder);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DBGSelectionResponder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormIntrigueCardHinter.NativeFieldInfoPtr_selectionResponder), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000D0F RID: 3343
		private static readonly IntPtr NativeFieldInfoPtr_selectionResponder;

		// Token: 0x04000D10 RID: 3344
		private static readonly IntPtr NativeMethodInfoPtr_Start_Protected_Virtual_Void_0;

		// Token: 0x04000D11 RID: 3345
		private static readonly IntPtr NativeMethodInfoPtr_SetHint_Public_Virtual_Void_String_Boolean_0;

		// Token: 0x04000D12 RID: 3346
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
