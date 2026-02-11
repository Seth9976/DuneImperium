using System;
using Canis.messages;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Canis.entities
{
	// Token: 0x020000D6 RID: 214
	public class EntityName : EntityNameForParent<Entity>
	{
		// Token: 0x060009F9 RID: 2553 RVA: 0x00005B12 File Offset: 0x00003D12
		// Note: this type is marked as 'beforefieldinit'.
		static EntityName()
		{
			Il2CppClassPointerStore<EntityName>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.entities", "EntityName");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EntityName>.NativeClassPtr);
			EntityName.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_Entity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EntityName>.NativeClassPtr, 100665407);
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x00043D6C File Offset: 0x00041F6C
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 565362, RefRangeEnd = 565369, XrefRangeStart = 565359, XrefRangeEnd = 565362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EntityName(string name, Func<SerializedEntity, Match, Entity, Entity> entityGen = null, Action<Entity, Entity> assignEntToParent = null)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EntityName>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(entityGen);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(assignEntToParent);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EntityName.NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_Entity_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x00005B4B File Offset: 0x00003D4B
		public EntityName(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040006D3 RID: 1747
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_String_Func_4_SerializedEntity_Match_Entity_Entity_Action_2_Entity_Entity_0;
	}
}
