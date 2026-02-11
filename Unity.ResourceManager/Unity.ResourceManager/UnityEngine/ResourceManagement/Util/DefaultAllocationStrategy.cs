using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.ResourceManagement.Util
{
	// Token: 0x02000021 RID: 33
	public class DefaultAllocationStrategy : Object
	{
		// Token: 0x060001C7 RID: 455 RVA: 0x0000BF84 File Offset: 0x0000A184
		// Note: this type is marked as 'beforefieldinit'.
		static DefaultAllocationStrategy()
		{
			Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.ResourceManager.dll", "UnityEngine.ResourceManagement.Util", "DefaultAllocationStrategy");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr);
			DefaultAllocationStrategy.NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr, 100663620);
			DefaultAllocationStrategy.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr, 100663621);
			DefaultAllocationStrategy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr, 100663622);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1138743, XrefRangeEnd = 1138744, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Object New(Type type, int typeHash)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref typeHash;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAllocationStrategy.NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000C050 File Offset: 0x0000A250
		[CallerCount(21425)]
		[CachedScanResults(RefRangeStart = 3378, RefRangeEnd = 24803, XrefRangeStart = 3378, XrefRangeEnd = 24803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Release(int typeHash, Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref typeHash;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(obj);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAllocationStrategy.NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DefaultAllocationStrategy()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DefaultAllocationStrategy>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DefaultAllocationStrategy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x00002B4C File Offset: 0x00000D4C
		public DefaultAllocationStrategy(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000136 RID: 310
		private static readonly IntPtr NativeMethodInfoPtr_New_Public_Virtual_Final_New_Object_Type_Int32_0;

		// Token: 0x04000137 RID: 311
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Virtual_Final_New_Void_Int32_Object_0;

		// Token: 0x04000138 RID: 312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
