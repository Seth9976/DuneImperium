using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using Unity.Properties.Internal;

namespace Unity.Properties
{
	// Token: 0x02000018 RID: 24
	public static class PropertyBag : Object
	{
		// Token: 0x060000AF RID: 175 RVA: 0x00002576 File Offset: 0x00000776
		// Note: this type is marked as 'beforefieldinit'.
		static PropertyBag()
		{
			Il2CppClassPointerStore<PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PropertiesModule.dll", "Unity.Properties", "PropertyBag");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PropertyBag>.NativeClassPtr);
			PropertyBag.NativeMethodInfoPtr_Register_Public_Static_Void_PropertyBag_1_TContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PropertyBag>.NativeClassPtr, 100663371);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000059AC File Offset: 0x00003BAC
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 1230863, RefRangeEnd = 1230874, XrefRangeStart = 1230848, XrefRangeEnd = 1230863, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Register<TContainer>(PropertyBag<TContainer> propertyBag)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(propertyBag);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PropertyBag.MethodInfoStoreGeneric_Register_Public_Static_Void_PropertyBag_1_TContainer_0<TContainer>.Pointer, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000025AF File Offset: 0x000007AF
		public PropertyBag(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000025B8 File Offset: 0x000007B8
		public static void AcceptWithSpecializedVisitor<TContainer>(IPropertyBag<TContainer> properties, IPropertyBagVisitor visitor, ref TContainer container)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x000059E4 File Offset: 0x00003BE4
		public static void RegisterArray<TElement>()
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<Il2CppArrayBase<TElement>>(new ArrayPropertyBag<TElement>());
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x000025C5 File Offset: 0x000007C5
		public static void RegisterArray<TContainer, TElement>()
		{
			PropertyBag.RegisterArray<TElement>();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00005A0C File Offset: 0x00003C0C
		public static void RegisterList<TElement>()
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<List<TElement>>(new ListPropertyBag<TElement>());
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000025CE File Offset: 0x000007CE
		public static void RegisterList<TContainer, TElement>()
		{
			PropertyBag.RegisterList<TElement>();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x000025D7 File Offset: 0x000007D7
		public static void RegisterHashSet<TElement>()
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000025E4 File Offset: 0x000007E4
		public static void RegisterHashSet<TContainer, TElement>()
		{
			PropertyBag.RegisterHashSet<TElement>();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00005A34 File Offset: 0x00003C34
		public static void RegisterDictionary<TKey, TValue>()
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<Dictionary<TKey, TValue>>(new DictionaryPropertyBag<TKey, TValue>());
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000025ED File Offset: 0x000007ED
		public static void RegisterDictionary<TContainer, TKey, TValue>()
		{
			PropertyBag.RegisterDictionary<TKey, TValue>();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00005A5C File Offset: 0x00003C5C
		public static void RegisterIList<TList, TElement>() where TList : IList<TElement>
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<TList>(new IndexedCollectionPropertyBag<TList, TElement>());
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x000025F6 File Offset: 0x000007F6
		public static void RegisterIList<TContainer, TList, TElement>() where TList : IList<TElement>
		{
			PropertyBag.RegisterIList<TList, TElement>();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00005A84 File Offset: 0x00003C84
		public static void RegisterISet<TSet, TElement>()
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<TSet>(new SetPropertyBagBase<TSet, TElement>());
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x000025FF File Offset: 0x000007FF
		public static void RegisterISet<TContainer, TSet, TElement>()
		{
			PropertyBag.RegisterISet<TSet, TElement>();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00005AAC File Offset: 0x00003CAC
		public static void RegisterIDictionary<TDictionary, TKey, TValue>() where TDictionary : IDictionary<TKey, TValue>
		{
			bool flag = Unity.Properties.Internal.PropertyBagStore.TypedStore.PropertyBag == null;
			if (flag)
			{
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<TDictionary>(new KeyValueCollectionPropertyBag<TDictionary, TKey, TValue>());
				Unity.Properties.Internal.PropertyBagStore.AddPropertyBag<KeyValuePair<TKey, TValue>>(new KeyValuePairPropertyBag<TKey, TValue>());
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002608 File Offset: 0x00000808
		public static void RegisterIDictionary<TContainer, TDictionary, TKey, TValue>() where TDictionary : IDictionary<TKey, TValue>
		{
			PropertyBag.RegisterIDictionary<TDictionary, TKey, TValue>();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00005AE0 File Offset: 0x00003CE0
		public static TContainer CreateInstance<TContainer>()
		{
			IPropertyBag<TContainer> propertyBag = Unity.Properties.Internal.PropertyBagStore.GetPropertyBag<TContainer>();
			bool flag = propertyBag == null;
			if (flag)
			{
				throw new MissingPropertyBagException(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<TContainer>()));
			}
			return propertyBag.CreateInstance();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00005B18 File Offset: 0x00003D18
		public static IPropertyBag GetPropertyBag(Type type)
		{
			return Unity.Properties.Internal.PropertyBagStore.GetPropertyBag(type);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00005B30 File Offset: 0x00003D30
		public static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
		{
			return Unity.Properties.Internal.PropertyBagStore.GetPropertyBag<TContainer>();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00005B48 File Offset: 0x00003D48
		public static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
		{
			return Unity.Properties.Internal.PropertyBagStore.TryGetPropertyBagForValue<TValue>(ref value, out propertyBag);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00005B64 File Offset: 0x00003D64
		public static bool Exists<TContainer>()
		{
			return Unity.Properties.Internal.PropertyBagStore.Exists<TContainer>();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00005B7C File Offset: 0x00003D7C
		public static bool Exists(Type type)
		{
			return Unity.Properties.Internal.PropertyBagStore.Exists(type);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00005B94 File Offset: 0x00003D94
		public static IEnumerable<Type> GetAllTypesWithAPropertyBag()
		{
			return Unity.Properties.Internal.PropertyBagStore.AllTypes;
		}

		// Token: 0x0400004D RID: 77
		private static readonly IntPtr NativeMethodInfoPtr_Register_Public_Static_Void_PropertyBag_1_TContainer_0;

		// Token: 0x02000064 RID: 100
		private sealed class MethodInfoStoreGeneric_Register_Public_Static_Void_PropertyBag_1_TContainer_0<TContainer>
		{
			// Token: 0x040000FC RID: 252
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PropertyBag.NativeMethodInfoPtr_Register_Public_Static_Void_PropertyBag_1_TContainer_0, Il2CppClassPointerStore<PropertyBag>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TContainer>.NativeClassPtr)) }))));
		}
	}
}
