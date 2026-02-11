using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	// Token: 0x02000092 RID: 146
	public class ITableProvider : Il2CppObjectBase
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x00004A09 File Offset: 0x00002C09
		// Note: this type is marked as 'beforefieldinit'.
		static ITableProvider()
		{
			Il2CppClassPointerStore<ITableProvider>.NativeClassPtr = IL2CPP.GetIl2CppClass("Unity.Localization.dll", "UnityEngine.Localization.Settings", "ITableProvider");
			ITableProvider.NativeMethodInfoPtr_ProvideTableAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TTable_String_Locale_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ITableProvider>.NativeClassPtr, 100664551);
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00023AEC File Offset: 0x00021CEC
		[CallerCount(0)]
		public unsafe virtual AsyncOperationHandle<TTable> ProvideTableAsync<TTable>(string tableCollectionName, Locale locale) where TTable : LocalizationTable
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(tableCollectionName);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(locale);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ITableProvider.MethodInfoStoreGeneric_ProvideTableAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TTable_String_Locale_0<TTable>.Pointer), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return new AsyncOperationHandle<TTable>(intPtr);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00004A38 File Offset: 0x00002C38
		public ITableProvider(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040004EF RID: 1263
		private static readonly IntPtr NativeMethodInfoPtr_ProvideTableAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TTable_String_Locale_0;

		// Token: 0x0200015B RID: 347
		private sealed class MethodInfoStoreGeneric_ProvideTableAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TTable_String_Locale_0<TTable>
		{
			// Token: 0x04000A55 RID: 2645
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ITableProvider.NativeMethodInfoPtr_ProvideTableAsync_Public_Abstract_Virtual_New_AsyncOperationHandle_1_TTable_String_Locale_0, Il2CppClassPointerStore<ITableProvider>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TTable>.NativeClassPtr)) }))));
		}
	}
}
