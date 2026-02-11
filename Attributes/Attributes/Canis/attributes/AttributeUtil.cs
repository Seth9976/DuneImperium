using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.attributes
{
	// Token: 0x0200000C RID: 12
	public static class AttributeUtil : Object
	{
		// Token: 0x06000053 RID: 83 RVA: 0x00004A74 File Offset: 0x00002C74
		// Note: this type is marked as 'beforefieldinit'.
		static AttributeUtil()
		{
			Il2CppClassPointerStore<AttributeUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("Attributes.dll", "Canis.attributes", "AttributeUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUtil>.NativeClassPtr);
			AttributeUtil.NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IEnumerable_1_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUtil>.NativeClassPtr, 100663341);
			AttributeUtil.NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttributeUtil>.NativeClassPtr, 100663342);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004ACC File Offset: 0x00002CCC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 1215582, RefRangeEnd = 1215583, XrefRangeStart = 1215559, XrefRangeEnd = 1215582, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAttributeString(this IEnumerable<IAttribute> attributes)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attributes);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUtil.NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IEnumerable_1_IAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00004B08 File Offset: 0x00002D08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1215583, XrefRangeEnd = 1215637, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static string GetAttributeString(this IAttribute attribute)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attribute);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttributeUtil.NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IAttribute_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000221F File Offset: 0x0000041F
		public AttributeUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000034 RID: 52
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IEnumerable_1_IAttribute_0;

		// Token: 0x04000035 RID: 53
		private static readonly IntPtr NativeMethodInfoPtr_GetAttributeString_Public_Static_String_IAttribute_0;

		// Token: 0x02000033 RID: 51
		[ObfuscatedName("Canis.attributes.AttributeUtil+<>O")]
		public static class __O : Object
		{
			// Token: 0x060002F2 RID: 754 RVA: 0x0000320B File Offset: 0x0000140B
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<AttributeUtil.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AttributeUtil>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttributeUtil.__O>.NativeClassPtr);
				AttributeUtil.__O.NativeFieldInfoPtr__0___GetAttributeString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttributeUtil.__O>.NativeClassPtr, "<0>__GetAttributeString");
			}

			// Token: 0x060002F3 RID: 755 RVA: 0x0000323F File Offset: 0x0000143F
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000115 RID: 277
			// (get) Token: 0x060002F4 RID: 756 RVA: 0x0000E11C File Offset: 0x0000C31C
			// (set) Token: 0x060002F5 RID: 757 RVA: 0x00003248 File Offset: 0x00001448
			public unsafe static Func<IAttribute, string> _0___GetAttributeString
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(AttributeUtil.__O.NativeFieldInfoPtr__0___GetAttributeString, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<IAttribute, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(AttributeUtil.__O.NativeFieldInfoPtr__0___GetAttributeString, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040001DB RID: 475
			private static readonly IntPtr NativeFieldInfoPtr__0___GetAttributeString;
		}
	}
}
