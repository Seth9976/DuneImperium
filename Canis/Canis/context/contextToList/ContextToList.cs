using System;
using Canis.context.propertiesphrases;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;

namespace Canis.context.contextToList
{
	// Token: 0x0200012D RID: 301
	[Serializable]
	public class ContextToList : Object
	{
		// Token: 0x06000DD6 RID: 3542 RVA: 0x000543E8 File Offset: 0x000525E8
		// Note: this type is marked as 'beforefieldinit'.
		static ContextToList()
		{
			Il2CppClassPointerStore<ContextToList>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.context.contextToList", "ContextToList");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContextToList>.NativeClassPtr);
			ContextToList.NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList>.NativeClassPtr, 100666358);
			ContextToList.NativeMethodInfoPtr_Count_Public_ContextToInt_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList>.NativeClassPtr, 100666359);
			ContextToList.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContextToList>.NativeClassPtr, 100666360);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x00054454 File Offset: 0x00052654
		[CallerCount(0)]
		public unsafe virtual IEnumerable ErasedEvaluate(Context context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(context);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ContextToList.NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerable>(intPtr3) : null;
			}
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x000544B0 File Offset: 0x000526B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 577069, XrefRangeEnd = 577074, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToInt Count()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList.NativeMethodInfoPtr_Count_Public_ContextToInt_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ContextToInt>(intPtr3) : null;
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x000544F0 File Offset: 0x000526F0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ContextToList()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContextToList>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ContextToList.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x000070D0 File Offset: 0x000052D0
		public ContextToList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400096B RID: 2411
		private static readonly IntPtr NativeMethodInfoPtr_ErasedEvaluate_Public_Abstract_Virtual_New_IEnumerable_Context_0;

		// Token: 0x0400096C RID: 2412
		private static readonly IntPtr NativeMethodInfoPtr_Count_Public_ContextToInt_0;

		// Token: 0x0400096D RID: 2413
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
