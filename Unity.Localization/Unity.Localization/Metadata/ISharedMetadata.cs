using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace UnityEngine.Localization.Metadata
{
	// Token: 0x020000D5 RID: 213
	public class ISharedMetadata : Il2CppObjectBase
	{
		// Token: 0x06000AED RID: 2797 RVA: 0x00032554 File Offset: 0x00030754
		// Note: this type is marked as 'beforefieldinit'.
		static ISharedMetadata()
		{
			Il2CppClassPointerStore<ISharedMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Metadata", "ISharedMetadata");
			ISharedMetadata.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISharedMetadata>.NativeClassPtr, 100665109);
			ISharedMetadata.NativeMethodInfoPtr_AddEntry_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISharedMetadata>.NativeClassPtr, 100665110);
			ISharedMetadata.NativeMethodInfoPtr_RemoveEntry_Public_Abstract_Virtual_New_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ISharedMetadata>.NativeClassPtr, 100665111);
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x000325B8 File Offset: 0x000307B8
		[CallerCount(0)]
		public unsafe virtual bool Contains(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISharedMetadata.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x0003260C File Offset: 0x0003080C
		[CallerCount(0)]
		public unsafe virtual void AddEntry(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISharedMetadata.NativeMethodInfoPtr_AddEntry_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00032658 File Offset: 0x00030858
		[CallerCount(0)]
		public unsafe virtual void RemoveEntry(long keyId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref keyId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ISharedMetadata.NativeMethodInfoPtr_RemoveEntry_Public_Abstract_Virtual_New_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00006939 File Offset: 0x00004B39
		public ISharedMetadata(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040007AD RID: 1965
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Int64_0;

		// Token: 0x040007AE RID: 1966
		private static readonly IntPtr NativeMethodInfoPtr_AddEntry_Public_Abstract_Virtual_New_Void_Int64_0;

		// Token: 0x040007AF RID: 1967
		private static readonly IntPtr NativeMethodInfoPtr_RemoveEntry_Public_Abstract_Virtual_New_Void_Int64_0;
	}
}
