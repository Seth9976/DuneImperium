using System;
using dwd.core.match;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine.Events;
using worm.canis.data.enums;
using worm.match.data;

// Token: 0x0200001C RID: 28
public class WormEventsForAgentColorSubscriber : VersionedSubscriber<WormColorData>
{
	// Token: 0x06000108 RID: 264 RVA: 0x0001BF04 File Offset: 0x0001A104
	// Note: this type is marked as 'beforefieldinit'.
	static WormEventsForAgentColorSubscriber()
	{
		Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormEventsForAgentColorSubscriber");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr);
		WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_colorEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, "colorEventPairs");
		WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_mentatEventPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, "mentatEventPairs");
		WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, "entities");
		WormEventsForAgentColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, 100663446);
		WormEventsForAgentColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, 100663447);
	}

	// Token: 0x06000109 RID: 265 RVA: 0x0001BF98 File Offset: 0x0001A198
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687753, XrefRangeEnd = 687824, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override void dirtyUpdate()
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormEventsForAgentColorSubscriber.NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0001BFD4 File Offset: 0x0001A1D4
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687824, XrefRangeEnd = 687839, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormEventsForAgentColorSubscriber()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForAgentColorSubscriber.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x0600010B RID: 267 RVA: 0x000027F5 File Offset: 0x000009F5
	public WormEventsForAgentColorSubscriber(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000048 RID: 72
	// (get) Token: 0x0600010C RID: 268 RVA: 0x0001C010 File Offset: 0x0001A210
	// (set) Token: 0x0600010D RID: 269 RVA: 0x000027FE File Offset: 0x000009FE
	public unsafe List<WormEventsForAgentColorSubscriber.ColorEventPair> colorEventPairs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_colorEventPairs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForAgentColorSubscriber.ColorEventPair>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_colorEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x0600010E RID: 270 RVA: 0x0001C040 File Offset: 0x0001A240
	// (set) Token: 0x0600010F RID: 271 RVA: 0x0000281D File Offset: 0x00000A1D
	public unsafe List<WormEventsForAgentColorSubscriber.ColorEventPair> mentatEventPairs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_mentatEventPairs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormEventsForAgentColorSubscriber.ColorEventPair>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_mentatEventPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x1700004A RID: 74
	// (get) Token: 0x06000110 RID: 272 RVA: 0x0001C070 File Offset: 0x0001A270
	// (set) Token: 0x06000111 RID: 273 RVA: 0x0000283C File Offset: 0x00000A3C
	public unsafe Entities entities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_entities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Entities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x0400009D RID: 157
	private static readonly IntPtr NativeFieldInfoPtr_colorEventPairs;

	// Token: 0x0400009E RID: 158
	private static readonly IntPtr NativeFieldInfoPtr_mentatEventPairs;

	// Token: 0x0400009F RID: 159
	private static readonly IntPtr NativeFieldInfoPtr_entities;

	// Token: 0x040000A0 RID: 160
	private static readonly IntPtr NativeMethodInfoPtr_dirtyUpdate_Protected_Virtual_Void_0;

	// Token: 0x040000A1 RID: 161
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002B5 RID: 693
	[Serializable]
	public sealed class ColorEventPair : ValueType
	{
		// Token: 0x06001C47 RID: 7239 RVA: 0x0006F0B0 File Offset: 0x0006D2B0
		// Note: this type is marked as 'beforefieldinit'.
		static ColorEventPair()
		{
			Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.ColorEventPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, "ColorEventPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.ColorEventPair>.NativeClassPtr);
			WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.ColorEventPair>.NativeClassPtr, "PieceColor");
			WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.ColorEventPair>.NativeClassPtr, "Event");
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x000103EF File Offset: 0x0000E5EF
		public ColorEventPair(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public ColorEventPair()
			: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.ColorEventPair>.NativeClassPtr))
		{
		}

		// Token: 0x170007B1 RID: 1969
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x0006F104 File Offset: 0x0006D304
		// (set) Token: 0x06001C4B RID: 7243 RVA: 0x0001040A File Offset: 0x0000E60A
		public unsafe PieceColor PieceColor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_PieceColor)) = value;
			}
		}

		// Token: 0x170007B2 RID: 1970
		// (get) Token: 0x06001C4C RID: 7244 RVA: 0x0006F12C File Offset: 0x0006D32C
		// (set) Token: 0x06001C4D RID: 7245 RVA: 0x00010425 File Offset: 0x0000E625
		public unsafe UnityEvent Event
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormEventsForAgentColorSubscriber.ColorEventPair.NativeFieldInfoPtr_Event), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001056 RID: 4182
		private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

		// Token: 0x04001057 RID: 4183
		private static readonly IntPtr NativeFieldInfoPtr_Event;
	}

	// Token: 0x020002B6 RID: 694
	[ObfuscatedName("WormEventsForAgentColorSubscriber+<>c")]
	[Serializable]
	public sealed class __c : Object
	{
		// Token: 0x06001C4E RID: 7246 RVA: 0x0006F15C File Offset: 0x0006D35C
		// Note: this type is marked as 'beforefieldinit'.
		static __c()
		{
			Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber>.NativeClassPtr, "<>c");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr);
			WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, "<>9");
			WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, "<>9__4_0");
			WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, "<>9__4_1");
			WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, 100663449);
			WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, 100663450);
			WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Boolean_EntityComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr, 100663451);
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x0006F200 File Offset: 0x0006D400
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormEventsForAgentColorSubscriber.__c>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001C50 RID: 7248 RVA: 0x0006F23C File Offset: 0x0006D43C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687739, XrefRangeEnd = 687746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_0(EntityComponent c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C51 RID: 7249 RVA: 0x0006F28C File Offset: 0x0006D48C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 687746, XrefRangeEnd = 687753, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool _dirtyUpdate_b__4_1(EntityComponent c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(c);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormEventsForAgentColorSubscriber.__c.NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Boolean_EntityComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001C52 RID: 7250 RVA: 0x00010444 File Offset: 0x0000E644
		public __c(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007B3 RID: 1971
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x0006F2DC File Offset: 0x0006D4DC
		// (set) Token: 0x06001C54 RID: 7252 RVA: 0x0001044D File Offset: 0x0000E64D
		public unsafe static WormEventsForAgentColorSubscriber.__c __9
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEventsForAgentColorSubscriber.__c>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B4 RID: 1972
		// (get) Token: 0x06001C55 RID: 7253 RVA: 0x0006F304 File Offset: 0x0006D504
		// (set) Token: 0x06001C56 RID: 7254 RVA: 0x0001045F File Offset: 0x0000E65F
		public unsafe static Func<EntityComponent, bool> __9__4_0
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170007B5 RID: 1973
		// (get) Token: 0x06001C57 RID: 7255 RVA: 0x0006F32C File Offset: 0x0006D52C
		// (set) Token: 0x06001C58 RID: 7256 RVA: 0x00010471 File Offset: 0x0000E671
		public unsafe static Func<EntityComponent, bool> __9__4_1
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_1, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<EntityComponent, bool>>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WormEventsForAgentColorSubscriber.__c.NativeFieldInfoPtr___9__4_1, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001058 RID: 4184
		private static readonly IntPtr NativeFieldInfoPtr___9;

		// Token: 0x04001059 RID: 4185
		private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

		// Token: 0x0400105A RID: 4186
		private static readonly IntPtr NativeFieldInfoPtr___9__4_1;

		// Token: 0x0400105B RID: 4187
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400105C RID: 4188
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_0_Internal_Boolean_EntityComponent_0;

		// Token: 0x0400105D RID: 4189
		private static readonly IntPtr NativeMethodInfoPtr__dirtyUpdate_b__4_1_Internal_Boolean_EntityComponent_0;
	}
}
