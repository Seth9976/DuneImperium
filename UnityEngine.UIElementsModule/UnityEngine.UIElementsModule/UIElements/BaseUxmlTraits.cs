using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine.UIElements
{
	// Token: 0x02000204 RID: 516
	public class BaseUxmlTraits : Object
	{
		// Token: 0x060027F8 RID: 10232 RVA: 0x000AFF04 File Offset: 0x000AE104
		// Note: this type is marked as 'beforefieldinit'.
		static BaseUxmlTraits()
		{
			Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UIElementsModule.dll", "UnityEngine.UIElements", "BaseUxmlTraits");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr);
			BaseUxmlTraits.NativeFieldInfoPtr__canHaveAnyAttribute_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr, "<canHaveAnyAttribute>k__BackingField");
			BaseUxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr, 100669319);
			BaseUxmlTraits.NativeMethodInfoPtr_set_canHaveAnyAttribute_Protected_set_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr, 100669320);
		}

		// Token: 0x060027F9 RID: 10233 RVA: 0x000AFF70 File Offset: 0x000AE170
		[CallerCount(8)]
		[CachedScanResults(RefRangeStart = 344029, RefRangeEnd = 344037, XrefRangeStart = 344028, XrefRangeEnd = 344029, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe BaseUxmlTraits()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BaseUxmlTraits>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseUxmlTraits.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060027FE RID: 10238 RVA: 0x000102A0 File Offset: 0x0000E4A0
		// (set) Token: 0x060027FA RID: 10234 RVA: 0x000AFFAC File Offset: 0x000AE1AC
		public unsafe bool canHaveAnyAttribute
		{
			get
			{
				return this._canHaveAnyAttribute_k__BackingField;
			}
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 288083, RefRangeEnd = 288084, XrefRangeStart = 288083, XrefRangeEnd = 288084, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BaseUxmlTraits.NativeMethodInfoPtr_set_canHaveAnyAttribute_Protected_set_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x0001027C File Offset: 0x0000E47C
		public BaseUxmlTraits(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x060027FC RID: 10236 RVA: 0x000AFFEC File Offset: 0x000AE1EC
		// (set) Token: 0x060027FD RID: 10237 RVA: 0x00010285 File Offset: 0x0000E485
		public unsafe bool _canHaveAnyAttribute_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUxmlTraits.NativeFieldInfoPtr__canHaveAnyAttribute_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BaseUxmlTraits.NativeFieldInfoPtr__canHaveAnyAttribute_k__BackingField)) = value;
			}
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x000102A8 File Offset: 0x0000E4A8
		public virtual IEnumerable<UxmlAttributeDescription> uxmlAttributesDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x06002800 RID: 10240 RVA: 0x000102B5 File Offset: 0x0000E4B5
		public virtual IEnumerable<UxmlChildElementDescription> uxmlChildElementsDescription
		{
			get
			{
				throw new NotSupportedException("Method unstripping failed");
			}
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000102C2 File Offset: 0x0000E4C2
		public IEnumerable<UxmlAttributeDescription> GetAllAttributeDescriptionForType(Type t)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04001C5A RID: 7258
		private static readonly IntPtr NativeFieldInfoPtr__canHaveAnyAttribute_k__BackingField;

		// Token: 0x04001C5B RID: 7259
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04001C5C RID: 7260
		private static readonly IntPtr NativeMethodInfoPtr_set_canHaveAnyAttribute_Protected_set_Void_Boolean_0;

		// Token: 0x02000517 RID: 1303
		[Serializable]
		public sealed class <>c
		{
		}

		// Token: 0x02000518 RID: 1304
		public sealed class <GetAllAttributeDescriptionForType>d__9
		{
		}

		// Token: 0x02000519 RID: 1305
		public sealed class <get_uxmlAttributesDescription>d__6
		{
		}

		// Token: 0x0200051A RID: 1306
		public sealed class <get_uxmlChildElementsDescription>d__8
		{
		}
	}
}
