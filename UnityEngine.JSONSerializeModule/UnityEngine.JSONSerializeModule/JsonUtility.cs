using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public static class JsonUtility : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x0000205C File Offset: 0x0000025C
		// Note: this type is marked as 'beforefieldinit'.
		static JsonUtility()
		{
			Il2CppClassPointerStore<JsonUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.JSONSerializeModule.dll", "UnityEngine", "JsonUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr);
			JsonUtility.NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663297);
			JsonUtility.NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663298);
			JsonUtility.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663299);
			JsonUtility.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663300);
			JsonUtility.NativeMethodInfoPtr_FromJson_Public_Static_T_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663301);
			JsonUtility.NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663302);
			JsonUtility.NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<JsonUtility>.NativeClassPtr, 100663303);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002118 File Offset: 0x00000318
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1272861, XrefRangeEnd = 1272863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJsonInternal(Object obj, bool prettyPrint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002164 File Offset: 0x00000364
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272865, RefRangeEnd = 1272866, XrefRangeStart = 1272863, XrefRangeEnd = 1272865, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromJsonInternal(string json, Object objectToOverwrite, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectToOverwrite);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000021CC File Offset: 0x000003CC
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 1272877, RefRangeEnd = 1272884, XrefRangeStart = 1272866, XrefRangeEnd = 1272877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002208 File Offset: 0x00000408
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272896, RefRangeEnd = 1272897, XrefRangeStart = 1272884, XrefRangeEnd = 1272896, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string ToJson(Object obj, bool prettyPrint)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref prettyPrint;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002254 File Offset: 0x00000454
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1272905, RefRangeEnd = 1272906, XrefRangeStart = 1272897, XrefRangeEnd = 1272905, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T FromJson<T>(string json)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002294 File Offset: 0x00000494
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 1272919, RefRangeEnd = 1272922, XrefRangeStart = 1272906, XrefRangeEnd = 1272919, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Object FromJson(string json, Type type)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(type);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022EC File Offset: 0x000004EC
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 1272933, RefRangeEnd = 1272937, XrefRangeStart = 1272922, XrefRangeEnd = 1272933, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void FromJsonOverwrite(string json, Object objectToOverwrite)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(json);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(objectToOverwrite);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(JsonUtility.NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		public JsonUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_ToJsonInternal_Private_Static_String_Object_Boolean_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_FromJsonInternal_Private_Static_Object_String_Object_Type_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Object_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_ToJson_Public_Static_String_Object_Boolean_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_T_String_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_FromJson_Public_Static_Object_String_Type_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_FromJsonOverwrite_Public_Static_Void_String_Object_0;

		// Token: 0x02000003 RID: 3
		private sealed class MethodInfoStoreGeneric_FromJson_Public_Static_T_String_0<T>
		{
			// Token: 0x04000008 RID: 8
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(JsonUtility.NativeMethodInfoPtr_FromJson_Public_Static_T_String_0, Il2CppClassPointerStore<JsonUtility>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}
	}
}
