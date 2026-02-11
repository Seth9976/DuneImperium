using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace JetBrains.Annotations
{
	// Token: 0x02000060 RID: 96
	public sealed class CollectionAccessAttribute : Attribute
	{
		// Token: 0x06000318 RID: 792 RVA: 0x0001EBD8 File Offset: 0x0001CDD8
		// Note: this type is marked as 'beforefieldinit'.
		static CollectionAccessAttribute()
		{
			Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "JetBrains.Annotations", "CollectionAccessAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr);
			CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, "<CollectionAccessType>k__BackingField");
			CollectionAccessAttribute.NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr, 100663587);
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0001EC30 File Offset: 0x0001CE30
		[CallerCount(28)]
		[CachedScanResults(RefRangeStart = 346333, RefRangeEnd = 346361, XrefRangeStart = 346333, XrefRangeEnd = 346361, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CollectionAccessAttribute(CollectionAccessType collectionAccessType)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CollectionAccessAttribute>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref collectionAccessType;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CollectionAccessAttribute.NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x000039F2 File Offset: 0x00001BF2
		public CollectionAccessAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0001EC78 File Offset: 0x0001CE78
		// (set) Token: 0x0600031C RID: 796 RVA: 0x000039FB File Offset: 0x00001BFB
		public unsafe CollectionAccessType _CollectionAccessType_k__BackingField
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CollectionAccessAttribute.NativeFieldInfoPtr__CollectionAccessType_k__BackingField)) = value;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600031D RID: 797 RVA: 0x00003A16 File Offset: 0x00001C16
		public CollectionAccessType CollectionAccessType
		{
			get
			{
				return this._CollectionAccessType_k__BackingField;
			}
		}

		// Token: 0x04000248 RID: 584
		private static readonly IntPtr NativeFieldInfoPtr__CollectionAccessType_k__BackingField;

		// Token: 0x04000249 RID: 585
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_CollectionAccessType_0;
	}
}
