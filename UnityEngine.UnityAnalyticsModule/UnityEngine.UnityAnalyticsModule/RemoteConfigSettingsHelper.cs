using System;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000004 RID: 4
	public static class RemoteConfigSettingsHelper : Object
	{
		// Token: 0x06000052 RID: 82 RVA: 0x00003378 File Offset: 0x00001578
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteConfigSettingsHelper()
		{
			Il2CppClassPointerStore<RemoteConfigSettingsHelper>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteConfigSettingsHelper");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteConfigSettingsHelper>.NativeClassPtr);
			RemoteConfigSettingsHelper.GetSafeMapDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeMapDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMap");
			RemoteConfigSettingsHelper.GetSafeMapKeysDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeMapKeysDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMapKeys");
			RemoteConfigSettingsHelper.GetSafeMapTypesDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeMapTypesDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeMapTypes");
			RemoteConfigSettingsHelper.GetSafeNumberDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeNumberDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeNumber");
			RemoteConfigSettingsHelper.GetSafeFloatDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeFloatDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeFloat");
			RemoteConfigSettingsHelper.GetSafeBoolDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeBoolDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeBool");
			RemoteConfigSettingsHelper.GetSafeStringValueDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeStringValueDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeStringValue");
			RemoteConfigSettingsHelper.GetSafeArrayDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArray");
			RemoteConfigSettingsHelper.GetSafeArraySizeDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArraySizeDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArraySize");
			RemoteConfigSettingsHelper.GetSafeArrayArrayDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayArrayDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayArray");
			RemoteConfigSettingsHelper.GetSafeArrayMapDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayMapDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayMap");
			RemoteConfigSettingsHelper.GetSafeArrayTypeDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayTypeDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayType");
			RemoteConfigSettingsHelper.GetSafeNumberArrayDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeNumberArrayDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeNumberArray");
			RemoteConfigSettingsHelper.GetSafeArrayFloatDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayFloatDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayFloat");
			RemoteConfigSettingsHelper.GetSafeArrayBoolDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayBoolDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayBool");
			RemoteConfigSettingsHelper.GetSafeArrayStringValueDelegateField = IL2CPP.ResolveICall<RemoteConfigSettingsHelper.GetSafeArrayStringValueDelegate>("UnityEngine.RemoteConfigSettingsHelper::GetSafeArrayStringValue");
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002348 File Offset: 0x00000548
		public RemoteConfigSettingsHelper(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002351 File Offset: 0x00000551
		public static IntPtr GetSafeMap(IntPtr m, string key)
		{
			return RemoteConfigSettingsHelper.GetSafeMapDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key));
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003498 File Offset: 0x00001698
		public static Il2CppStringArray GetSafeMapKeys(IntPtr m)
		{
			IntPtr intPtr = RemoteConfigSettingsHelper.GetSafeMapKeysDelegateField(m);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000034C0 File Offset: 0x000016C0
		public static Il2CppStructArray<RemoteConfigSettingsHelper.Tag> GetSafeMapTypes(IntPtr m)
		{
			IntPtr intPtr = RemoteConfigSettingsHelper.GetSafeMapTypesDelegateField(m);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<RemoteConfigSettingsHelper.Tag>>(intPtr2) : null;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002364 File Offset: 0x00000564
		public static long GetSafeNumber(IntPtr m, string key, long defaultValue)
		{
			return RemoteConfigSettingsHelper.GetSafeNumberDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002378 File Offset: 0x00000578
		public static float GetSafeFloat(IntPtr m, string key, float defaultValue)
		{
			return RemoteConfigSettingsHelper.GetSafeFloatDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000238C File Offset: 0x0000058C
		public static bool GetSafeBool(IntPtr m, string key, bool defaultValue)
		{
			return RemoteConfigSettingsHelper.GetSafeBoolDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000034E8 File Offset: 0x000016E8
		public static string GetSafeStringValue(IntPtr m, string key, string defaultValue)
		{
			IntPtr intPtr = RemoteConfigSettingsHelper.GetSafeStringValueDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(defaultValue));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000023A0 File Offset: 0x000005A0
		public static IntPtr GetSafeArray(IntPtr m, string key)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayDelegateField(m, IL2CPP.ManagedStringToIl2Cpp(key));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000023B3 File Offset: 0x000005B3
		public static long GetSafeArraySize(IntPtr a)
		{
			return RemoteConfigSettingsHelper.GetSafeArraySizeDelegateField(a);
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000023C0 File Offset: 0x000005C0
		public static IntPtr GetSafeArrayArray(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayArrayDelegateField(a, i);
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000023CE File Offset: 0x000005CE
		public static IntPtr GetSafeArrayMap(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayMapDelegateField(a, i);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000023DC File Offset: 0x000005DC
		public static RemoteConfigSettingsHelper.Tag GetSafeArrayType(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayTypeDelegateField(a, i);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000023EA File Offset: 0x000005EA
		public static long GetSafeNumberArray(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeNumberArrayDelegateField(a, i);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000023F8 File Offset: 0x000005F8
		public static float GetSafeArrayFloat(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayFloatDelegateField(a, i);
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002406 File Offset: 0x00000606
		public static bool GetSafeArrayBool(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetSafeArrayBoolDelegateField(a, i);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00003514 File Offset: 0x00001714
		public static string GetSafeArrayStringValue(IntPtr a, long i)
		{
			IntPtr intPtr = RemoteConfigSettingsHelper.GetSafeArrayStringValueDelegateField(a, i);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003534 File Offset: 0x00001734
		public static IDictionary<string, Object> GetDictionary(IntPtr m, string key)
		{
			bool flag = m == IntPtr.Zero;
			IDictionary<string, Object> dictionary;
			if (flag)
			{
				dictionary = null;
			}
			else
			{
				bool flag2 = !String.IsNullOrEmpty(key);
				if (flag2)
				{
					m = RemoteConfigSettingsHelper.GetSafeMap(m, key);
					bool flag3 = m == IntPtr.Zero;
					if (flag3)
					{
						return null;
					}
				}
				dictionary = RemoteConfigSettingsHelper.GetDictionary(m);
			}
			return dictionary;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002414 File Offset: 0x00000614
		public static IDictionary<string, Object> GetDictionary(IntPtr m)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000358C File Offset: 0x0000178C
		public static Object GetArrayArrayEntries(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetArrayEntries(RemoteConfigSettingsHelper.GetSafeArrayArray(a, i));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000035AC File Offset: 0x000017AC
		public static IDictionary<string, Object> GetArrayMapEntries(IntPtr a, long i)
		{
			return RemoteConfigSettingsHelper.GetDictionary(RemoteConfigSettingsHelper.GetSafeArrayMap(a, i));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x000035CC File Offset: 0x000017CC
		public static Il2CppArrayBase<T> GetArrayEntriesType<T>(IntPtr a, long size, Func<IntPtr, long, T> f)
		{
			Il2CppArrayBase<T> il2CppArrayBase = new Il2CppReferenceArray<T>((long)(checked((IntPtr)size)));
			for (long num = 0L; num < size; num += 1L)
			{
				il2CppArrayBase[(int)(checked((IntPtr)num))] = f.Invoke(a, num);
			}
			return il2CppArrayBase;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000360C File Offset: 0x0000180C
		public static Object GetArrayEntries(IntPtr a)
		{
			long safeArraySize = RemoteConfigSettingsHelper.GetSafeArraySize(a);
			bool flag = safeArraySize == 0L;
			Object @object;
			if (flag)
			{
				@object = null;
			}
			else
			{
				switch (RemoteConfigSettingsHelper.GetSafeArrayType(a, 0L))
				{
				case RemoteConfigSettingsHelper.Tag.kIntVal:
				case RemoteConfigSettingsHelper.Tag.kInt64Val:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<long>(a, safeArraySize, new Func<IntPtr, long, long>(RemoteConfigSettingsHelper.GetSafeNumberArray));
				case RemoteConfigSettingsHelper.Tag.kDoubleVal:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<float>(a, safeArraySize, new Func<IntPtr, long, float>(RemoteConfigSettingsHelper.GetSafeArrayFloat));
				case RemoteConfigSettingsHelper.Tag.kBoolVal:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<bool>(a, safeArraySize, new Func<IntPtr, long, bool>(RemoteConfigSettingsHelper.GetSafeArrayBool));
				case RemoteConfigSettingsHelper.Tag.kStringVal:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<string>(a, safeArraySize, new Func<IntPtr, long, string>(RemoteConfigSettingsHelper.GetSafeArrayStringValue));
				case RemoteConfigSettingsHelper.Tag.kArrayVal:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<Object>(a, safeArraySize, new Func<IntPtr, long, Object>(RemoteConfigSettingsHelper.GetArrayArrayEntries));
				case RemoteConfigSettingsHelper.Tag.kMapVal:
					return RemoteConfigSettingsHelper.GetArrayEntriesType<IDictionary<string, Object>>(a, safeArraySize, new Func<IntPtr, long, IDictionary<string, Object>>(RemoteConfigSettingsHelper.GetArrayMapEntries));
				}
				@object = null;
			}
			return @object;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002421 File Offset: 0x00000621
		public static Object GetMixedArrayEntries(IntPtr a)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000036F8 File Offset: 0x000018F8
		public static void SetDictKeyType(IntPtr m, IDictionary<string, Object> dict, string key, RemoteConfigSettingsHelper.Tag tag)
		{
			switch (tag)
			{
			case RemoteConfigSettingsHelper.Tag.kIntVal:
			case RemoteConfigSettingsHelper.Tag.kInt64Val:
				dict[key] = RemoteConfigSettingsHelper.GetSafeNumber(m, key, 0L);
				break;
			case RemoteConfigSettingsHelper.Tag.kDoubleVal:
				dict[key] = RemoteConfigSettingsHelper.GetSafeFloat(m, key, 0f);
				break;
			case RemoteConfigSettingsHelper.Tag.kBoolVal:
				dict[key] = RemoteConfigSettingsHelper.GetSafeBool(m, key, false);
				break;
			case RemoteConfigSettingsHelper.Tag.kStringVal:
				dict[key] = RemoteConfigSettingsHelper.GetSafeStringValue(m, key, "");
				break;
			case RemoteConfigSettingsHelper.Tag.kArrayVal:
				dict[key] = RemoteConfigSettingsHelper.GetArrayEntries(RemoteConfigSettingsHelper.GetSafeArray(m, key));
				break;
			case RemoteConfigSettingsHelper.Tag.kMixedArrayVal:
				dict[key] = RemoteConfigSettingsHelper.GetMixedArrayEntries(RemoteConfigSettingsHelper.GetSafeArray(m, key));
				break;
			case RemoteConfigSettingsHelper.Tag.kMapVal:
				dict[key] = RemoteConfigSettingsHelper.GetDictionary(RemoteConfigSettingsHelper.GetSafeMap(m, key));
				break;
			}
		}

		// Token: 0x0400002B RID: 43
		private static readonly RemoteConfigSettingsHelper.GetSafeMapDelegate GetSafeMapDelegateField;

		// Token: 0x0400002C RID: 44
		private static readonly RemoteConfigSettingsHelper.GetSafeMapKeysDelegate GetSafeMapKeysDelegateField;

		// Token: 0x0400002D RID: 45
		private static readonly RemoteConfigSettingsHelper.GetSafeMapTypesDelegate GetSafeMapTypesDelegateField;

		// Token: 0x0400002E RID: 46
		private static readonly RemoteConfigSettingsHelper.GetSafeNumberDelegate GetSafeNumberDelegateField;

		// Token: 0x0400002F RID: 47
		private static readonly RemoteConfigSettingsHelper.GetSafeFloatDelegate GetSafeFloatDelegateField;

		// Token: 0x04000030 RID: 48
		private static readonly RemoteConfigSettingsHelper.GetSafeBoolDelegate GetSafeBoolDelegateField;

		// Token: 0x04000031 RID: 49
		private static readonly RemoteConfigSettingsHelper.GetSafeStringValueDelegate GetSafeStringValueDelegateField;

		// Token: 0x04000032 RID: 50
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayDelegate GetSafeArrayDelegateField;

		// Token: 0x04000033 RID: 51
		private static readonly RemoteConfigSettingsHelper.GetSafeArraySizeDelegate GetSafeArraySizeDelegateField;

		// Token: 0x04000034 RID: 52
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayArrayDelegate GetSafeArrayArrayDelegateField;

		// Token: 0x04000035 RID: 53
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayMapDelegate GetSafeArrayMapDelegateField;

		// Token: 0x04000036 RID: 54
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayTypeDelegate GetSafeArrayTypeDelegateField;

		// Token: 0x04000037 RID: 55
		private static readonly RemoteConfigSettingsHelper.GetSafeNumberArrayDelegate GetSafeNumberArrayDelegateField;

		// Token: 0x04000038 RID: 56
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayFloatDelegate GetSafeArrayFloatDelegateField;

		// Token: 0x04000039 RID: 57
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayBoolDelegate GetSafeArrayBoolDelegateField;

		// Token: 0x0400003A RID: 58
		private static readonly RemoteConfigSettingsHelper.GetSafeArrayStringValueDelegate GetSafeArrayStringValueDelegateField;

		// Token: 0x0200002F RID: 47
		public enum Tag
		{
			// Token: 0x04000097 RID: 151
			kUnknown,
			// Token: 0x04000098 RID: 152
			kIntVal,
			// Token: 0x04000099 RID: 153
			kInt64Val,
			// Token: 0x0400009A RID: 154
			kUInt64Val,
			// Token: 0x0400009B RID: 155
			kDoubleVal,
			// Token: 0x0400009C RID: 156
			kBoolVal,
			// Token: 0x0400009D RID: 157
			kStringVal,
			// Token: 0x0400009E RID: 158
			kArrayVal,
			// Token: 0x0400009F RID: 159
			kMixedArrayVal,
			// Token: 0x040000A0 RID: 160
			kMapVal,
			// Token: 0x040000A1 RID: 161
			kMaxTags
		}

		// Token: 0x02000030 RID: 48
		// (Invoke) Token: 0x0600012C RID: 300
		private delegate IntPtr GetSafeMapDelegate(IntPtr m, IntPtr key);

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600012E RID: 302
		private delegate IntPtr GetSafeMapKeysDelegate(IntPtr m);

		// Token: 0x02000032 RID: 50
		// (Invoke) Token: 0x06000130 RID: 304
		private delegate IntPtr GetSafeMapTypesDelegate(IntPtr m);

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000132 RID: 306
		private delegate long GetSafeNumberDelegate(IntPtr m, IntPtr key, long defaultValue);

		// Token: 0x02000034 RID: 52
		// (Invoke) Token: 0x06000134 RID: 308
		private delegate float GetSafeFloatDelegate(IntPtr m, IntPtr key, float defaultValue);

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000136 RID: 310
		private delegate bool GetSafeBoolDelegate(IntPtr m, IntPtr key, bool defaultValue);

		// Token: 0x02000036 RID: 54
		// (Invoke) Token: 0x06000138 RID: 312
		private delegate IntPtr GetSafeStringValueDelegate(IntPtr m, IntPtr key, IntPtr defaultValue);

		// Token: 0x02000037 RID: 55
		// (Invoke) Token: 0x0600013A RID: 314
		private delegate IntPtr GetSafeArrayDelegate(IntPtr m, IntPtr key);

		// Token: 0x02000038 RID: 56
		// (Invoke) Token: 0x0600013C RID: 316
		private delegate long GetSafeArraySizeDelegate(IntPtr a);

		// Token: 0x02000039 RID: 57
		// (Invoke) Token: 0x0600013E RID: 318
		private delegate IntPtr GetSafeArrayArrayDelegate(IntPtr a, long i);

		// Token: 0x0200003A RID: 58
		// (Invoke) Token: 0x06000140 RID: 320
		private delegate IntPtr GetSafeArrayMapDelegate(IntPtr a, long i);

		// Token: 0x0200003B RID: 59
		// (Invoke) Token: 0x06000142 RID: 322
		private delegate RemoteConfigSettingsHelper.Tag GetSafeArrayTypeDelegate(IntPtr a, long i);

		// Token: 0x0200003C RID: 60
		// (Invoke) Token: 0x06000144 RID: 324
		private delegate long GetSafeNumberArrayDelegate(IntPtr a, long i);

		// Token: 0x0200003D RID: 61
		// (Invoke) Token: 0x06000146 RID: 326
		private delegate float GetSafeArrayFloatDelegate(IntPtr a, long i);

		// Token: 0x0200003E RID: 62
		// (Invoke) Token: 0x06000148 RID: 328
		private delegate bool GetSafeArrayBoolDelegate(IntPtr a, long i);

		// Token: 0x0200003F RID: 63
		// (Invoke) Token: 0x0600014A RID: 330
		private delegate IntPtr GetSafeArrayStringValueDelegate(IntPtr a, long i);
	}
}
