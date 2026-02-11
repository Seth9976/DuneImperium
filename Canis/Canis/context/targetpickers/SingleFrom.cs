using System;
using Canis.entities;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

namespace Canis.context.targetpickers
{
	// Token: 0x02000125 RID: 293
	public class SingleFrom : TakeFrom
	{
		// Token: 0x06000DA5 RID: 3493 RVA: 0x00006F23 File Offset: 0x00005123
		// Note: this type is marked as 'beforefieldinit'.
		static SingleFrom()
		{
			Il2CppClassPointerStore<SingleFrom>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.targetpickers", "SingleFrom");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SingleFrom>.NativeClassPtr);
			SingleFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SingleFrom>.NativeClassPtr, 100666336);
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000539BC File Offset: 0x00051BBC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 576853, XrefRangeEnd = 576854, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SingleFrom(Entity pile, Match m)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SingleFrom>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(pile);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(m);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SingleFrom.NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00006F5C File Offset: 0x0000515C
		public SingleFrom(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000951 RID: 2385
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Entity_Match_0;
	}
}
