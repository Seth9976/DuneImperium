using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace Canis.actions.serialized
{
	// Token: 0x02000211 RID: 529
	[Serializable]
	public class FallbackSerializedAction : SerializedAction
	{
		// Token: 0x0600164F RID: 5711 RVA: 0x00072F24 File Offset: 0x00071124
		// Note: this type is marked as 'beforefieldinit'.
		static FallbackSerializedAction()
		{
			Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr = IL2CPP.GetIl2CppClass("Canis.dll", "Canis.actions.serialized", "FallbackSerializedAction");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr);
			FallbackSerializedAction.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr, 100668378);
			FallbackSerializedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr, 100668379);
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x00072F7C File Offset: 0x0007117C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593312, XrefRangeEnd = 593344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FallbackSerializedAction(Dictionary<string, Object> parameters)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parameters);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackSerializedAction.NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00072FC8 File Offset: 0x000711C8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593344, XrefRangeEnd = 593348, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Action GenAction(Match match)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(match);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), FallbackSerializedAction.NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action>(intPtr3) : null;
			}
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x0000ABE4 File Offset: 0x00008DE4
		public FallbackSerializedAction(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000E5C RID: 3676
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Dictionary_2_String_Object_0;

		// Token: 0x04000E5D RID: 3677
		private static readonly IntPtr NativeMethodInfoPtr_GenAction_Protected_Virtual_Action_Match_0;

		// Token: 0x0200045D RID: 1117
		[ObfuscatedName("Canis.actions.serialized.FallbackSerializedAction+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x060031E8 RID: 12776 RVA: 0x000CDC38 File Offset: 0x000CBE38
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FallbackSerializedAction>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr);
				FallbackSerializedAction.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr, "<>9");
				FallbackSerializedAction.__c.NativeFieldInfoPtr___9__0_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr, "<>9__0_0");
				FallbackSerializedAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr, 100668381);
				FallbackSerializedAction.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_String_KeyValuePair_2_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr, 100668382);
			}

			// Token: 0x060031E9 RID: 12777 RVA: 0x000CDCB4 File Offset: 0x000CBEB4
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FallbackSerializedAction.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackSerializedAction.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060031EA RID: 12778 RVA: 0x000CDCF0 File Offset: 0x000CBEF0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 593307, XrefRangeEnd = 593312, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe string __ctor_b__0_0(KeyValuePair<string, Object> pair)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(pair));
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FallbackSerializedAction.__c.NativeMethodInfoPtr___ctor_b__0_0_Internal_String_KeyValuePair_2_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x060031EB RID: 12779 RVA: 0x00017E78 File Offset: 0x00016078
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x17000D2F RID: 3375
			// (get) Token: 0x060031EC RID: 12780 RVA: 0x000CDD40 File Offset: 0x000CBF40
			// (set) Token: 0x060031ED RID: 12781 RVA: 0x00017E81 File Offset: 0x00016081
			public unsafe static FallbackSerializedAction.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FallbackSerializedAction.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<FallbackSerializedAction.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FallbackSerializedAction.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17000D30 RID: 3376
			// (get) Token: 0x060031EE RID: 12782 RVA: 0x000CDD68 File Offset: 0x000CBF68
			// (set) Token: 0x060031EF RID: 12783 RVA: 0x00017E93 File Offset: 0x00016093
			public unsafe static Func<KeyValuePair<string, Object>, string> __9__0_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(FallbackSerializedAction.__c.NativeFieldInfoPtr___9__0_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<KeyValuePair<string, Object>, string>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(FallbackSerializedAction.__c.NativeFieldInfoPtr___9__0_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04001F3B RID: 7995
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x04001F3C RID: 7996
			private static readonly IntPtr NativeFieldInfoPtr___9__0_0;

			// Token: 0x04001F3D RID: 7997
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04001F3E RID: 7998
			private static readonly IntPtr NativeMethodInfoPtr___ctor_b__0_0_Internal_String_KeyValuePair_2_String_Object_0;
		}
	}
}
