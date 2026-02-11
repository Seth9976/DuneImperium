using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine
{
	// Token: 0x0200014A RID: 330
	public class ScriptableObject : Object
	{
		// Token: 0x06001910 RID: 6416 RVA: 0x00075D70 File Offset: 0x00073F70
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptableObject()
		{
			Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptableObject");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr);
			ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666752);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666753);
			ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666754);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666755);
			ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr, 100666756);
			ScriptableObject.SetDirtyDelegateField = IL2CPP.ResolveICall<ScriptableObject.SetDirtyDelegate>("UnityEngine.ScriptableObject::SetDirty");
			ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField = IL2CPP.ResolveICall<ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate>("UnityEngine.ScriptableObject::CreateScriptableObjectInstanceFromName");
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField = IL2CPP.ResolveICall<ScriptableObject.ResetAndApplyDefaultInstancesDelegate>("UnityEngine.ScriptableObject::ResetAndApplyDefaultInstances");
		}

		// Token: 0x06001911 RID: 6417 RVA: 0x00075E34 File Offset: 0x00074034
		[CallerCount(70)]
		[CachedScanResults(RefRangeStart = 667021, RefRangeEnd = 667091, XrefRangeStart = 667015, XrefRangeEnd = 667021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ScriptableObject()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001912 RID: 6418 RVA: 0x00075E70 File Offset: 0x00074070
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 667093, RefRangeEnd = 667098, XrefRangeStart = 667091, XrefRangeEnd = 667093, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateInstance(Type type)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
			}
		}

		// Token: 0x06001913 RID: 6419 RVA: 0x00075EB4 File Offset: 0x000740B4
		[CallerCount(21)]
		[CachedScanResults(RefRangeStart = 667105, RefRangeEnd = 667126, XrefRangeStart = 667098, XrefRangeEnd = 667105, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static T CreateInstance<T>() where T : ScriptableObject
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>.Pointer, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
		}

		// Token: 0x06001914 RID: 6420 RVA: 0x00075EE4 File Offset: 0x000740E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667126, XrefRangeEnd = 667128, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CreateScriptableObject(ScriptableObject self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(self);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001915 RID: 6421 RVA: 0x00075F1C File Offset: 0x0007411C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 667128, XrefRangeEnd = 667130, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static ScriptableObject CreateScriptableObjectInstanceFromType(Type type, bool applyDefaultsAndReset)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref applyDefaultsAndReset;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptableObject.NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr3) : null;
		}

		// Token: 0x06001916 RID: 6422 RVA: 0x00009C57 File Offset: 0x00007E57
		public ScriptableObject(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001917 RID: 6423 RVA: 0x00009C60 File Offset: 0x00007E60
		public void SetDirty()
		{
			ScriptableObject.SetDirtyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06001918 RID: 6424 RVA: 0x00075F70 File Offset: 0x00074170
		public static ScriptableObject CreateInstance(string className)
		{
			return ScriptableObject.CreateScriptableObjectInstanceFromName(className);
		}

		// Token: 0x06001919 RID: 6425 RVA: 0x00075F88 File Offset: 0x00074188
		public static ScriptableObject CreateInstance(Type type, Action<ScriptableObject> initialize)
		{
			bool flag = !Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<ScriptableObject>()).IsAssignableFrom(type);
			if (flag)
			{
				throw new ArgumentException("Type must inherit ScriptableObject.", "type");
			}
			ScriptableObject scriptableObject = ScriptableObject.CreateScriptableObjectInstanceFromType(type, false);
			try
			{
				initialize.Invoke(scriptableObject);
			}
			finally
			{
				ScriptableObject.ResetAndApplyDefaultInstances(scriptableObject);
			}
			return scriptableObject;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x00075FF0 File Offset: 0x000741F0
		public static ScriptableObject CreateScriptableObjectInstanceFromName(string className)
		{
			IntPtr intPtr = ScriptableObject.CreateScriptableObjectInstanceFromNameDelegateField(IL2CPP.ManagedStringToIl2Cpp(className));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<ScriptableObject>(intPtr2) : null;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x00009C72 File Offset: 0x00007E72
		public static void ResetAndApplyDefaultInstances(Object obj)
		{
			ScriptableObject.ResetAndApplyDefaultInstancesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
		}

		// Token: 0x0400165E RID: 5726
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400165F RID: 5727
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_ScriptableObject_Type_0;

		// Token: 0x04001660 RID: 5728
		private static readonly IntPtr NativeMethodInfoPtr_CreateInstance_Public_Static_T_0;

		// Token: 0x04001661 RID: 5729
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObject_Private_Static_Void_ScriptableObject_0;

		// Token: 0x04001662 RID: 5730
		private static readonly IntPtr NativeMethodInfoPtr_CreateScriptableObjectInstanceFromType_Internal_Static_ScriptableObject_Type_Boolean_0;

		// Token: 0x04001663 RID: 5731
		private static readonly ScriptableObject.SetDirtyDelegate SetDirtyDelegateField;

		// Token: 0x04001664 RID: 5732
		private static readonly ScriptableObject.CreateScriptableObjectInstanceFromNameDelegate CreateScriptableObjectInstanceFromNameDelegateField;

		// Token: 0x04001665 RID: 5733
		private static readonly ScriptableObject.ResetAndApplyDefaultInstancesDelegate ResetAndApplyDefaultInstancesDelegateField;

		// Token: 0x02000757 RID: 1879
		private sealed class MethodInfoStoreGeneric_CreateInstance_Public_Static_T_0<T>
		{
			// Token: 0x04002C6F RID: 11375
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(ScriptableObject.NativeMethodInfoPtr_CreateInstance_Public_Static_T_0, Il2CppClassPointerStore<ScriptableObject>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x02000758 RID: 1880
		// (Invoke) Token: 0x06003770 RID: 14192
		private delegate void SetDirtyDelegate(IntPtr @this);

		// Token: 0x02000759 RID: 1881
		// (Invoke) Token: 0x06003772 RID: 14194
		private delegate IntPtr CreateScriptableObjectInstanceFromNameDelegate(IntPtr className);

		// Token: 0x0200075A RID: 1882
		// (Invoke) Token: 0x06003774 RID: 14196
		private delegate void ResetAndApplyDefaultInstancesDelegate(IntPtr obj);
	}
}
