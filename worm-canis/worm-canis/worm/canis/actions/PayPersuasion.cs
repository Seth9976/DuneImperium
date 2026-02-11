using System;
using Canis;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace worm.canis.actions
{
	// Token: 0x0200026A RID: 618
	public class PayPersuasion : PayResources
	{
		// Token: 0x06001A3D RID: 6717 RVA: 0x0000B49C File Offset: 0x0000969C
		// Note: this type is marked as 'beforefieldinit'.
		static PayPersuasion()
		{
			Il2CppClassPointerStore<PayPersuasion>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-canis.dll", "worm.canis.actions", "PayPersuasion");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PayPersuasion>.NativeClassPtr);
			PayPersuasion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PayPersuasion>.NativeClassPtr, 100668254);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x000BEEB4 File Offset: 0x000BD0B4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 140481, RefRangeEnd = 140482, XrefRangeStart = 140475, XrefRangeEnd = 140481, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe PayPersuasion(int amt, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PayPersuasion>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref amt;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PayPersuasion.NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0000B4D5 File Offset: 0x000096D5
		public PayPersuasion(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001034 RID: 4148
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_Match_0;
	}
}
