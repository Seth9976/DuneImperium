using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine
{
	// Token: 0x0200011E RID: 286
	public sealed class Resources : Object
	{
		// Token: 0x06001711 RID: 5905 RVA: 0x0006E590 File Offset: 0x0006C790
		// Note: this type is marked as 'beforefieldinit'.
		static Resources()
		{
			Il2CppClassPointerStore<Resources>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "Resources");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Resources>.NativeClassPtr);
			Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666477);
			Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666478);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666479);
			Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666480);
			Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666481);
			Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666482);
			Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666483);
			Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666484);
			Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666485);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666486);
			Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666487);
			Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666488);
			Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Resources>.NativeClassPtr, 100666489);
			Resources.UnloadAssetImplResourceManagerDelegateField = IL2CPP.ResolveICall<Resources.UnloadAssetImplResourceManagerDelegate>("UnityEngine.Resources::UnloadAssetImplResourceManager");
			Resources.InstanceIDToObjectDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectDelegate>("UnityEngine.Resources::InstanceIDToObject");
			Resources.InstanceIDToObjectListDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDToObjectListDelegate>("UnityEngine.Resources::InstanceIDToObjectList");
			Resources.InstanceIDsToValidArray_InternalDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDsToValidArray_InternalDelegate>("UnityEngine.Resources::InstanceIDsToValidArray_Internal");
			Resources.InstanceIDIsValidDelegateField = IL2CPP.ResolveICall<Resources.InstanceIDIsValidDelegate>("UnityEngine.Resources::InstanceIDIsValid");
		}

		// Token: 0x06001712 RID: 5906 RVA: 0x0006E710 File Offset: 0x0006C910
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 660358, RefRangeEnd = 660362, XrefRangeStart = 660350, XrefRangeEnd = 660358, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> ConvertObjects<T>(Il2CppReferenceArray<Object> rawObjects) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rawObjects);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x06001713 RID: 5907 RVA: 0x0006E74C File Offset: 0x0006C94C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 660362, XrefRangeEnd = 660367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> FindObjectsOfTypeAll(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
			}
		}

		// Token: 0x06001714 RID: 5908 RVA: 0x0006E790 File Offset: 0x0006C990
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 660374, RefRangeEnd = 660378, XrefRangeStart = 660367, XrefRangeEnd = 660374, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001715 RID: 5909 RVA: 0x0006E7D4 File Offset: 0x0006C9D4
		[CallerCount(19)]
		[CachedScanResults(RefRangeStart = 660385, RefRangeEnd = 660404, XrefRangeStart = 660378, XrefRangeEnd = 660385, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T Load<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06001716 RID: 5910 RVA: 0x0006E814 File Offset: 0x0006CA14
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 660409, RefRangeEnd = 660415, XrefRangeStart = 660404, XrefRangeEnd = 660409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object Load(string path, Type systemTypeInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06001717 RID: 5911 RVA: 0x0006E86C File Offset: 0x0006CA6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 660421, RefRangeEnd = 660422, XrefRangeStart = 660415, XrefRangeEnd = 660421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsync<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_LoadAsync_Public_Static_ResourceRequest_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
			}
		}

		// Token: 0x06001718 RID: 5912 RVA: 0x0006E8B0 File Offset: 0x0006CAB0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660427, RefRangeEnd = 660429, XrefRangeStart = 660422, XrefRangeEnd = 660427, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ResourceRequest LoadAsync(string path, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ResourceRequest>(intPtr3) : null;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x0006E908 File Offset: 0x0006CB08
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660434, RefRangeEnd = 660436, XrefRangeStart = 660429, XrefRangeEnd = 660434, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppReferenceArray<Object> LoadAll(string path, Type systemTypeInstance)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(systemTypeInstance);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Object>>(intPtr3) : null;
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x0006E960 File Offset: 0x0006CB60
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 660450, RefRangeEnd = 660453, XrefRangeStart = 660436, XrefRangeEnd = 660450, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Il2CppArrayBase<T> LoadAll<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return Il2CppArrayBase<T>.WrapNativeGenericArrayPointer(intPtr);
			}
		}

		// Token: 0x0600171B RID: 5915 RVA: 0x0006E99C File Offset: 0x0006CB9C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 660455, RefRangeEnd = 660456, XrefRangeStart = 660453, XrefRangeEnd = 660455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object GetBuiltinResource(Type type, string path)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(path);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x0600171C RID: 5916 RVA: 0x0006E9F4 File Offset: 0x0006CBF4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660463, RefRangeEnd = 660465, XrefRangeStart = 660456, XrefRangeEnd = 660463, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T GetBuiltinResource<T>(string path) where T : Object
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x0600171D RID: 5917 RVA: 0x0006EA34 File Offset: 0x0006CC34
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 660470, RefRangeEnd = 660472, XrefRangeStart = 660465, XrefRangeEnd = 660470, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void UnloadAsset(Object assetToUnload)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(assetToUnload);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600171E RID: 5918 RVA: 0x0006EA6C File Offset: 0x0006CC6C
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 660474, RefRangeEnd = 660477, XrefRangeStart = 660472, XrefRangeEnd = 660474, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static AsyncOperation UnloadUnusedAssets()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Resources.NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<AsyncOperation>(intPtr3) : null;
		}

		// Token: 0x0600171F RID: 5919 RVA: 0x0000911D File Offset: 0x0000731D
		public Resources(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001720 RID: 5920 RVA: 0x0006EAA0 File Offset: 0x0006CCA0
		public static Il2CppArrayBase<T> FindObjectsOfTypeAll<T>() where T : Object
		{
			return Resources.ConvertObjects<T>(Resources.FindObjectsOfTypeAll(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>())));
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00009126 File Offset: 0x00007326
		public static void UnloadAssetImplResourceManager(Object assetToUnload)
		{
			Resources.UnloadAssetImplResourceManagerDelegateField(IL2CPP.Il2CppObjectBaseToPtr(assetToUnload));
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x0006EAC8 File Offset: 0x0006CCC8
		public static Object InstanceIDToObject(int instanceID)
		{
			IntPtr intPtr = Resources.InstanceIDToObjectDelegateField(instanceID);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00009138 File Offset: 0x00007338
		public static void InstanceIDToObjectList(IntPtr instanceIDs, int instanceCount, List<Object> objects)
		{
			Resources.InstanceIDToObjectListDelegateField(instanceIDs, instanceCount, IL2CPP.Il2CppObjectBaseToPtr(objects));
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x0006EAF0 File Offset: 0x0006CCF0
		public static void InstanceIDToObjectList(Unity.Collections.NativeArray<int> instanceIDs, List<Object> objects)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = objects == null;
			if (flag2)
			{
				throw new ArgumentNullException("objects");
			}
			bool flag3 = instanceIDs.Length == 0;
			if (flag3)
			{
				objects.Clear();
			}
			else
			{
				Resources.InstanceIDToObjectList((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, objects);
			}
		}

		// Token: 0x06001725 RID: 5925 RVA: 0x0000914C File Offset: 0x0000734C
		public static void InstanceIDsToValidArray_Internal(IntPtr instanceIDs, int instanceCount, IntPtr validArray, int validArrayCount)
		{
			Resources.InstanceIDsToValidArray_InternalDelegateField(instanceIDs, instanceCount, validArray, validArrayCount);
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x0000915C File Offset: 0x0000735C
		public static bool InstanceIDIsValid(int instanceId)
		{
			return Resources.InstanceIDIsValidDelegateField(instanceId);
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x0006EB60 File Offset: 0x0006CD60
		public static void InstanceIDsToValidArray(Unity.Collections.NativeArray<int> instanceIDs, Unity.Collections.NativeArray<bool> validArray)
		{
			bool flag = !instanceIDs.IsCreated;
			if (flag)
			{
				throw new ArgumentException("NativeArray is uninitialized", "instanceIDs");
			}
			bool flag2 = !validArray.IsCreated;
			if (flag2)
			{
				throw new ArgumentException("NativeArray is uninitialized", "validArray");
			}
			bool flag3 = instanceIDs.Length != validArray.Length;
			if (flag3)
			{
				throw new ArgumentException("Size mismatch! Both arrays must be the same length.");
			}
			bool flag4 = instanceIDs.Length == 0;
			if (!flag4)
			{
				Resources.InstanceIDsToValidArray_Internal((IntPtr)instanceIDs.GetUnsafeReadOnlyPtr<int>(), instanceIDs.Length, (IntPtr)validArray.GetUnsafePtr<bool>(), validArray.Length);
			}
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x0006EC08 File Offset: 0x0006CE08
		public unsafe static void InstanceIDsToValidArray(ReadOnlySpan<int> instanceIDs, Span<bool> validArray)
		{
			bool flag = instanceIDs.Length != validArray.Length;
			if (flag)
			{
				throw new ArgumentException("Size mismatch! Both arrays must be the same length.");
			}
			bool flag2 = instanceIDs.Length == 0;
			if (!flag2)
			{
				fixed (int* pinnableReference = instanceIDs.GetPinnableReference())
				{
					int* ptr = pinnableReference;
					fixed (bool* pinnableReference2 = validArray.GetPinnableReference())
					{
						bool* ptr2 = pinnableReference2;
						Resources.InstanceIDsToValidArray_Internal((IntPtr)((void*)ptr), instanceIDs.Length, (IntPtr)((void*)ptr2), validArray.Length);
					}
				}
			}
		}

		// Token: 0x04001502 RID: 5378
		private static readonly IntPtr NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04001503 RID: 5379
		private static readonly IntPtr NativeMethodInfoPtr_FindObjectsOfTypeAll_Public_Static_Il2CppReferenceArray_1_Object_Type_0;

		// Token: 0x04001504 RID: 5380
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_0;

		// Token: 0x04001505 RID: 5381
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_T_String_0;

		// Token: 0x04001506 RID: 5382
		private static readonly IntPtr NativeMethodInfoPtr_Load_Public_Static_Object_String_Type_0;

		// Token: 0x04001507 RID: 5383
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0;

		// Token: 0x04001508 RID: 5384
		private static readonly IntPtr NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_Type_0;

		// Token: 0x04001509 RID: 5385
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppReferenceArray_1_Object_String_Type_0;

		// Token: 0x0400150A RID: 5386
		private static readonly IntPtr NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0;

		// Token: 0x0400150B RID: 5387
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_Object_Type_String_0;

		// Token: 0x0400150C RID: 5388
		private static readonly IntPtr NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0;

		// Token: 0x0400150D RID: 5389
		private static readonly IntPtr NativeMethodInfoPtr_UnloadAsset_Public_Static_Void_Object_0;

		// Token: 0x0400150E RID: 5390
		private static readonly IntPtr NativeMethodInfoPtr_UnloadUnusedAssets_Public_Static_AsyncOperation_0;

		// Token: 0x0400150F RID: 5391
		private static readonly Resources.UnloadAssetImplResourceManagerDelegate UnloadAssetImplResourceManagerDelegateField;

		// Token: 0x04001510 RID: 5392
		private static readonly Resources.InstanceIDToObjectDelegate InstanceIDToObjectDelegateField;

		// Token: 0x04001511 RID: 5393
		private static readonly Resources.InstanceIDToObjectListDelegate InstanceIDToObjectListDelegateField;

		// Token: 0x04001512 RID: 5394
		private static readonly Resources.InstanceIDsToValidArray_InternalDelegate InstanceIDsToValidArray_InternalDelegateField;

		// Token: 0x04001513 RID: 5395
		private static readonly Resources.InstanceIDIsValidDelegate InstanceIDIsValidDelegateField;

		// Token: 0x02000715 RID: 1813
		private sealed class MethodInfoStoreGeneric_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0<T>
		{
			// Token: 0x04002C2C RID: 11308
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_ConvertObjects_Internal_Static_Il2CppArrayBase_1_T_Il2CppReferenceArray_1_Object_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000716 RID: 1814
		private sealed class MethodInfoStoreGeneric_Load_Public_Static_T_String_0<T>
		{
			// Token: 0x04002C2D RID: 11309
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_Load_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000717 RID: 1815
		private sealed class MethodInfoStoreGeneric_LoadAsync_Public_Static_ResourceRequest_String_0<T>
		{
			// Token: 0x04002C2E RID: 11310
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_LoadAsync_Public_Static_ResourceRequest_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000718 RID: 1816
		private sealed class MethodInfoStoreGeneric_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0<T>
		{
			// Token: 0x04002C2F RID: 11311
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_LoadAll_Public_Static_Il2CppArrayBase_1_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000719 RID: 1817
		private sealed class MethodInfoStoreGeneric_GetBuiltinResource_Public_Static_T_String_0<T>
		{
			// Token: 0x04002C30 RID: 11312
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(Resources.NativeMethodInfoPtr_GetBuiltinResource_Public_Static_T_String_0, Il2CppClassPointerStore<Resources>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x0200071A RID: 1818
		// (Invoke) Token: 0x06003701 RID: 14081
		private delegate void UnloadAssetImplResourceManagerDelegate(IntPtr assetToUnload);

		// Token: 0x0200071B RID: 1819
		// (Invoke) Token: 0x06003703 RID: 14083
		private delegate IntPtr InstanceIDToObjectDelegate(int instanceID);

		// Token: 0x0200071C RID: 1820
		// (Invoke) Token: 0x06003705 RID: 14085
		private delegate void InstanceIDToObjectListDelegate(IntPtr instanceIDs, int instanceCount, IntPtr objects);

		// Token: 0x0200071D RID: 1821
		// (Invoke) Token: 0x06003707 RID: 14087
		private delegate void InstanceIDsToValidArray_InternalDelegate(IntPtr instanceIDs, int instanceCount, IntPtr validArray, int validArrayCount);

		// Token: 0x0200071E RID: 1822
		// (Invoke) Token: 0x06003709 RID: 14089
		private delegate bool InstanceIDIsValidDelegate(int instanceId);
	}
}
