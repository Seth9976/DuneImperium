using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.UIElements.UIR
{
	// Token: 0x0200025C RID: 604
	public class BasicNodePool<T> : LinkedPool<BasicNode<T>>
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x000BF8D4 File Offset: 0x000BDAD4
		// Note: this type is marked as 'beforefieldinit'.
		static BasicNodePool()
		{
			Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements.UIR", "BasicNodePool`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr);
			BasicNodePool<T>.NativeMethodInfoPtr_Reset_Private_Static_Void_BasicNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr, 100669863);
			BasicNodePool<T>.NativeMethodInfoPtr_Create_Private_Static_BasicNode_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr, 100669864);
			BasicNodePool<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr, 100669865);
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x000BF97C File Offset: 0x000BDB7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350335, XrefRangeEnd = 350336, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Reset(BasicNode<T> node)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(node);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicNodePool<T>.NativeMethodInfoPtr_Reset_Private_Static_Void_BasicNode_1_T_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x000BF9B4 File Offset: 0x000BDBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350336, XrefRangeEnd = 350341, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BasicNode<T> Create()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicNodePool<T>.NativeMethodInfoPtr_Create_Private_Static_BasicNode_1_T_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<BasicNode<T>>(intPtr3) : null;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x000BF9E8 File Offset: 0x000BDBE8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350348, RefRangeEnd = 350349, XrefRangeStart = 350341, XrefRangeEnd = 350348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BasicNodePool()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BasicNodePool<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BasicNodePool<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x000120F7 File Offset: 0x000102F7
		public BasicNodePool(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001FDF RID: 8159
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Private_Static_Void_BasicNode_1_T_0;

		// Token: 0x04001FE0 RID: 8160
		private static readonly IntPtr NativeMethodInfoPtr_Create_Private_Static_BasicNode_1_T_0;

		// Token: 0x04001FE1 RID: 8161
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
