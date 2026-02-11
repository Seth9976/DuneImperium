using System;
using Canis.actions.serialized;
using Canis.attributes;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace Canis.actions
{
	// Token: 0x020001A0 RID: 416
	public class SerializedChangeAttribute : SerializedAction
	{
		// Token: 0x0600120F RID: 4623 RVA: 0x000628F8 File Offset: 0x00060AF8
		// Note: this type is marked as 'beforefieldinit'.
		static SerializedChangeAttribute()
		{
			Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions", "SerializedChangeAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr);
			SerializedChangeAttribute.NativeFieldInfoPtr_Attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, "Attribute");
			SerializedChangeAttribute.NativeMethodInfoPtr_IsMatchingConstructor_Private_Static_Boolean_ConstructorInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, 100667134);
			SerializedChangeAttribute.NativeMethodInfoPtr_TryInvoke_Private_Static_Action_ConstructorInfo_IAttributeDefinition_Object_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, 100667135);
			SerializedChangeAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, 100667136);
			SerializedChangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, 100667137);
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0006298C File Offset: 0x00060B8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584949, XrefRangeEnd = 584955, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsMatchingConstructor(ConstructorInfo constructorInfo)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructorInfo);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChangeAttribute.NativeMethodInfoPtr_IsMatchingConstructor_Private_Static_Boolean_ConstructorInfo_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x000629D0 File Offset: 0x00060BD0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 584972, RefRangeEnd = 584973, XrefRangeStart = 584955, XrefRangeEnd = 584972, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Action TryInvoke(ConstructorInfo constructor, IAttributeDefinition attrDef, Object value, Match match)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(constructor);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrDef);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(match);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChangeAttribute.NativeMethodInfoPtr_TryInvoke_Private_Static_Action_ConstructorInfo_IAttributeDefinition_Object_Match_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00062A4C File Offset: 0x00060C4C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 584973, XrefRangeEnd = 585021, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SerializedChangeAttribute.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x00062AA8 File Offset: 0x00060CA8
		[CallerCount(220)]
		[CachedScanResults(RefRangeStart = 1, RefRangeEnd = 221, XrefRangeStart = 1, XrefRangeEnd = 221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SerializedChangeAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SerializedChangeAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00008F1D File Offset: 0x0000711D
		public SerializedChangeAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00062AE4 File Offset: 0x00060CE4
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00008F26 File Offset: 0x00007126
		public unsafe IAttribute Attribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeAttribute.NativeFieldInfoPtr_Attribute);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IAttribute>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SerializedChangeAttribute.NativeFieldInfoPtr_Attribute), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000BCE RID: 3022
		private static readonly IntPtr NativeFieldInfoPtr_Attribute;

		// Token: 0x04000BCF RID: 3023
		private static readonly IntPtr NativeMethodInfoPtr_IsMatchingConstructor_Private_Static_Boolean_ConstructorInfo_0;

		// Token: 0x04000BD0 RID: 3024
		private static readonly IntPtr NativeMethodInfoPtr_TryInvoke_Private_Static_Action_ConstructorInfo_IAttributeDefinition_Object_Match_0;

		// Token: 0x04000BD1 RID: 3025
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x04000BD2 RID: 3026
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020003DE RID: 990
		[ObfuscatedName("Canis.actions.SerializedChangeAttribute+<>O")]
		public static class __O : Object
		{
			// Token: 0x06002A16 RID: 10774 RVA: 0x000141ED File Offset: 0x000123ED
			// Note: this type is marked as 'beforefieldinit'.
			static __O()
			{
				Il2CppClassPointerStore<SerializedChangeAttribute.__O>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SerializedChangeAttribute>.NativeClassPtr, "<>O");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SerializedChangeAttribute.__O>.NativeClassPtr);
				SerializedChangeAttribute.__O.NativeFieldInfoPtr__0___IsMatchingConstructor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SerializedChangeAttribute.__O>.NativeClassPtr, "<0>__IsMatchingConstructor");
			}

			// Token: 0x06002A17 RID: 10775 RVA: 0x00014221 File Offset: 0x00012421
			public __O(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000AA7 RID: 2727
			// (get) Token: 0x06002A18 RID: 10776 RVA: 0x000B4FB8 File Offset: 0x000B31B8
			// (set) Token: 0x06002A19 RID: 10777 RVA: 0x0001422A File Offset: 0x0001242A
			public unsafe static Func<ConstructorInfo, bool> _0___IsMatchingConstructor
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SerializedChangeAttribute.__O.NativeFieldInfoPtr__0___IsMatchingConstructor, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ConstructorInfo, bool>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SerializedChangeAttribute.__O.NativeFieldInfoPtr__0___IsMatchingConstructor, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001A4C RID: 6732
			private static readonly IntPtr NativeFieldInfoPtr__0___IsMatchingConstructor;
		}
	}
}
