using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace dwd.core.platform.websocket
{
	// Token: 0x0200001C RID: 28
	public static class PlatformMessageTypes : Object
	{
		// Token: 0x0600014E RID: 334 RVA: 0x00009FF4 File Offset: 0x000081F4
		// Note: this type is marked as 'beforefieldinit'.
		static PlatformMessageTypes()
		{
			Il2CppClassPointerStore<PlatformMessageTypes>.NativeClassPtr = IL2CPP.GetIl2CppClass("platform.dll", "dwd.core.platform.websocket", "PlatformMessageTypes");
			PlatformMessageTypes.NativeFieldInfoPtr_TypeLookup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformMessageTypes>.NativeClassPtr, "TypeLookup");
			PlatformMessageTypes.NativeMethodInfoPtr_GetType_Public_Static_Type_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMessageTypes>.NativeClassPtr, 100663563);
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000A044 File Offset: 0x00008244
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167438, XrefRangeEnd = 1167445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetType(string typeName)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(typeName);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMessageTypes.NativeMethodInfoPtr_GetType_Public_Static_Type_String_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002785 File Offset: 0x00000985
		public PlatformMessageTypes(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000151 RID: 337 RVA: 0x0000A088 File Offset: 0x00008288
		// (set) Token: 0x06000152 RID: 338 RVA: 0x0000278E File Offset: 0x0000098E
		public unsafe static Dictionary<string, Type> TypeLookup
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PlatformMessageTypes.NativeFieldInfoPtr_TypeLookup, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Dictionary<string, Type>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlatformMessageTypes.NativeFieldInfoPtr_TypeLookup, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040000F7 RID: 247
		private static readonly IntPtr NativeFieldInfoPtr_TypeLookup;

		// Token: 0x040000F8 RID: 248
		private static readonly IntPtr NativeMethodInfoPtr_GetType_Public_Static_Type_String_0;

		// Token: 0x02000078 RID: 120
		[ObfuscatedName("dwd.core.platform.websocket.PlatformMessageTypes+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x0600047D RID: 1149 RVA: 0x00013EA8 File Offset: 0x000120A8
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PlatformMessageTypes>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr);
				PlatformMessageTypes.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr, "<>9");
				PlatformMessageTypes.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr, 100663565);
				PlatformMessageTypes.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr, 100663566);
			}

			// Token: 0x0600047E RID: 1150 RVA: 0x00013F10 File Offset: 0x00012110
			[CallerCount(2676)]
			[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PlatformMessageTypes.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMessageTypes.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600047F RID: 1151 RVA: 0x00013F4C File Offset: 0x0001214C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1167434, XrefRangeEnd = 1167438, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool __cctor_b__1_0(Type t)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlatformMessageTypes.__c.NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06000480 RID: 1152 RVA: 0x000042F3 File Offset: 0x000024F3
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000481 RID: 1153 RVA: 0x00013F9C File Offset: 0x0001219C
			// (set) Token: 0x06000482 RID: 1154 RVA: 0x000042FC File Offset: 0x000024FC
			public unsafe static PlatformMessageTypes.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(PlatformMessageTypes.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<PlatformMessageTypes.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(PlatformMessageTypes.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002D2 RID: 722
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x040002D3 RID: 723
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x040002D4 RID: 724
			private static readonly IntPtr NativeMethodInfoPtr___cctor_b__1_0_Internal_Boolean_Type_0;
		}
	}
}
