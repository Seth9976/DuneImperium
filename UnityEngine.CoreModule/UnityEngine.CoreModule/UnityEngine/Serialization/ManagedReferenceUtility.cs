using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Serialization
{
	// Token: 0x0200031E RID: 798
	public sealed class ManagedReferenceUtility
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x000125D3 File Offset: 0x000107D3
		public static bool SetManagedReferenceIdForObjectInternal(Object obj, Object scriptObj, long refId)
		{
			return ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(scriptObj), refId);
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x000B4808 File Offset: 0x000B2A08
		public static bool SetManagedReferenceIdForObject(Object obj, Object scriptObj, long refId)
		{
			bool flag = scriptObj == null;
			bool flag2;
			if (flag)
			{
				flag2 = refId == -2L;
			}
			else
			{
				Type type = scriptObj.GetType();
				bool flag3 = type == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()) || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
				if (flag3)
				{
					throw new InvalidOperationException("Cannot assign an object deriving from UnityEngine.Object to a managed reference. This is not supported.");
				}
				flag2 = ManagedReferenceUtility.SetManagedReferenceIdForObjectInternal(obj, scriptObj, refId);
			}
			return flag2;
		}

		// Token: 0x06002DFE RID: 11774 RVA: 0x000125EC File Offset: 0x000107EC
		public static long GetManagedReferenceIdForObjectInternal(Object obj, Object scriptObj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), IL2CPP.Il2CppObjectBaseToPtr(scriptObj));
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x000B4870 File Offset: 0x000B2A70
		public static long GetManagedReferenceIdForObject(Object obj, Object scriptObj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdForObjectInternal(obj, scriptObj);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000B488C File Offset: 0x000B2A8C
		public static Object GetManagedReferenceInternal(Object obj, long id)
		{
			IntPtr intPtr = ManagedReferenceUtility.GetManagedReferenceInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj), id);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06002E01 RID: 11777 RVA: 0x000B48BC File Offset: 0x000B2ABC
		public static Object GetManagedReference(Object obj, long id)
		{
			return ManagedReferenceUtility.GetManagedReferenceInternal(obj, id);
		}

		// Token: 0x06002E02 RID: 11778 RVA: 0x000B48D8 File Offset: 0x000B2AD8
		public static Il2CppStructArray<long> GetManagedReferenceIdsForObjectInternal(Object obj)
		{
			IntPtr intPtr = ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegateField(IL2CPP.Il2CppObjectBaseToPtr(obj));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<long>>(intPtr2) : null;
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x000B4904 File Offset: 0x000B2B04
		public static Il2CppStructArray<long> GetManagedReferenceIds(Object obj)
		{
			return ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternal(obj);
		}

		// Token: 0x04002984 RID: 10628
		public const long RefIdUnknown = -1L;

		// Token: 0x04002985 RID: 10629
		public const long RefIdNull = -2L;

		// Token: 0x04002986 RID: 10630
		private static readonly ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegate SetManagedReferenceIdForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.SetManagedReferenceIdForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::SetManagedReferenceIdForObjectInternal");

		// Token: 0x04002987 RID: 10631
		private static readonly ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegate GetManagedReferenceIdForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdForObjectInternal");

		// Token: 0x04002988 RID: 10632
		private static readonly ManagedReferenceUtility.GetManagedReferenceInternalDelegate GetManagedReferenceInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceInternal");

		// Token: 0x04002989 RID: 10633
		private static readonly ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegate GetManagedReferenceIdsForObjectInternalDelegateField = IL2CPP.ResolveICall<ManagedReferenceUtility.GetManagedReferenceIdsForObjectInternalDelegate>("UnityEngine.Serialization.ManagedReferenceUtility::GetManagedReferenceIdsForObjectInternal");

		// Token: 0x02000B76 RID: 2934
		// (Invoke) Token: 0x06003FE1 RID: 16353
		private delegate bool SetManagedReferenceIdForObjectInternalDelegate(IntPtr obj, IntPtr scriptObj, long refId);

		// Token: 0x02000B77 RID: 2935
		// (Invoke) Token: 0x06003FE3 RID: 16355
		private delegate long GetManagedReferenceIdForObjectInternalDelegate(IntPtr obj, IntPtr scriptObj);

		// Token: 0x02000B78 RID: 2936
		// (Invoke) Token: 0x06003FE5 RID: 16357
		private delegate IntPtr GetManagedReferenceInternalDelegate(IntPtr obj, long id);

		// Token: 0x02000B79 RID: 2937
		// (Invoke) Token: 0x06003FE7 RID: 16359
		private delegate IntPtr GetManagedReferenceIdsForObjectInternalDelegate(IntPtr obj);
	}
}
