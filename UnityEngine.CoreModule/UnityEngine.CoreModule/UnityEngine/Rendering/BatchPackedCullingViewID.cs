using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine.Rendering
{
	// Token: 0x0200021F RID: 543
	[StructLayout(2)]
	public struct BatchPackedCullingViewID
	{
		// Token: 0x0600248D RID: 9357 RVA: 0x0009D3A8 File Offset: 0x0009B5A8
		// Note: this type is marked as 'beforefieldinit'.
		static BatchPackedCullingViewID()
		{
			Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "BatchPackedCullingViewID");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr);
			BatchPackedCullingViewID.NativeFieldInfoPtr_handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, "handle");
			BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100668065);
			BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100668066);
			BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, 100668067);
		}

		// Token: 0x0600248E RID: 9358 RVA: 0x0009D428 File Offset: 0x0009B628
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683250, XrefRangeEnd = 683251, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600248F RID: 9359 RVA: 0x0009D458 File Offset: 0x0009B658
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 335390, RefRangeEnd = 335396, XrefRangeStart = 335390, XrefRangeEnd = 335396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(BatchPackedCullingViewID other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002490 RID: 9360 RVA: 0x0009D498 File Offset: 0x0009B698
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683251, XrefRangeEnd = 683254, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BatchPackedCullingViewID.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002491 RID: 9361 RVA: 0x0000E571 File Offset: 0x0000C771
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BatchPackedCullingViewID>.NativeClassPtr, ref this));
		}

		// Token: 0x06002492 RID: 9362 RVA: 0x0009D4DC File Offset: 0x0009B6DC
		public static bool operator ==(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
		{
			return lhs.Equals(rhs);
		}

		// Token: 0x06002493 RID: 9363 RVA: 0x0009D4F8 File Offset: 0x0009B6F8
		public static bool operator !=(BatchPackedCullingViewID lhs, BatchPackedCullingViewID rhs)
		{
			return !lhs.Equals(rhs);
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x0009D518 File Offset: 0x0009B718
		public int GetInstanceID()
		{
			return (int)(this.handle & (ulong)(-1));
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x0009D534 File Offset: 0x0009B734
		public int GetSliceIndex()
		{
			return (int)(this.handle >> 32);
		}

		// Token: 0x04002010 RID: 8208
		private static readonly IntPtr NativeFieldInfoPtr_handle;

		// Token: 0x04002011 RID: 8209
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04002012 RID: 8210
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_BatchPackedCullingViewID_0;

		// Token: 0x04002013 RID: 8211
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x04002014 RID: 8212
		[FieldOffset(0)]
		public ulong handle;
	}
}
