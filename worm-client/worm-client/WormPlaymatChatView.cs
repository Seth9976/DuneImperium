using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using lotus;
using UnityEngine;
using worm;
using worm.canis.data.enums;

// Token: 0x02000023 RID: 35
public class WormPlaymatChatView : ChatView
{
	// Token: 0x06000172 RID: 370 RVA: 0x0001D618 File Offset: 0x0001B818
	// Note: this type is marked as 'beforefieldinit'.
	static WormPlaymatChatView()
	{
		Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr = IL2CPP.GetIl2CppClass("worm-client.dll", "", "WormPlaymatChatView");
		IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr);
		WormPlaymatChatView.NativeFieldInfoPtr_colorPairs = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, "colorPairs");
		WormPlaymatChatView.NativeFieldInfoPtr_entities = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, "entities");
		WormPlaymatChatView.NativeMethodInfoPtr_GetColor_Public_Virtual_Color_ClientChatMessage_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, 100663523);
		WormPlaymatChatView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, 100663524);
	}

	// Token: 0x06000173 RID: 371 RVA: 0x0001D698 File Offset: 0x0001B898
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688920, XrefRangeEnd = 688963, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe override Color GetColor(ClientChatMessage message)
	{
		IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
		checked
		{
			IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(message);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WormPlaymatChatView.NativeMethodInfoPtr_GetColor_Public_Virtual_Color_ClientChatMessage_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}
	}

	// Token: 0x06000174 RID: 372 RVA: 0x0001D6F0 File Offset: 0x0001B8F0
	[CallerCount(0)]
	[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 688963, XrefRangeEnd = 688971, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
	public unsafe WormPlaymatChatView()
		: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr))
	{
		IntPtr* ptr = null;
		IntPtr intPtr2;
		IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymatChatView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
		Il2CppException.RaiseExceptionIfNecessary(intPtr2);
	}

	// Token: 0x06000175 RID: 373 RVA: 0x00002AB0 File Offset: 0x00000CB0
	public WormPlaymatChatView(IntPtr pointer)
		: base(pointer)
	{
	}

	// Token: 0x17000060 RID: 96
	// (get) Token: 0x06000176 RID: 374 RVA: 0x0001D72C File Offset: 0x0001B92C
	// (set) Token: 0x06000177 RID: 375 RVA: 0x00002AB9 File Offset: 0x00000CB9
	public unsafe List<WormPlaymatChatView.ColorPair> colorPairs
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.NativeFieldInfoPtr_colorPairs);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<WormPlaymatChatView.ColorPair>>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.NativeFieldInfoPtr_colorPairs), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x17000061 RID: 97
	// (get) Token: 0x06000178 RID: 376 RVA: 0x0001D75C File Offset: 0x0001B95C
	// (set) Token: 0x06000179 RID: 377 RVA: 0x00002AD8 File Offset: 0x00000CD8
	public unsafe WormEntities entities
	{
		get
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.NativeFieldInfoPtr_entities);
			IntPtr intPtr2 = *intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<WormEntities>(intPtr2) : null;
		}
		set
		{
			IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.NativeFieldInfoPtr_entities), IL2CPP.Il2CppObjectBaseToPtr(value));
		}
	}

	// Token: 0x040000E3 RID: 227
	private static readonly IntPtr NativeFieldInfoPtr_colorPairs;

	// Token: 0x040000E4 RID: 228
	private static readonly IntPtr NativeFieldInfoPtr_entities;

	// Token: 0x040000E5 RID: 229
	private static readonly IntPtr NativeMethodInfoPtr_GetColor_Public_Virtual_Color_ClientChatMessage_0;

	// Token: 0x040000E6 RID: 230
	private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

	// Token: 0x020002BE RID: 702
	[Serializable]
	[StructLayout(2)]
	public struct ColorPair
	{
		// Token: 0x06001C9D RID: 7325 RVA: 0x0006FFD8 File Offset: 0x0006E1D8
		// Note: this type is marked as 'beforefieldinit'.
		static ColorPair()
		{
			Il2CppClassPointerStore<WormPlaymatChatView.ColorPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, "ColorPair");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymatChatView.ColorPair>.NativeClassPtr);
			WormPlaymatChatView.ColorPair.NativeFieldInfoPtr_PieceColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymatChatView.ColorPair>.NativeClassPtr, "PieceColor");
			WormPlaymatChatView.ColorPair.NativeFieldInfoPtr_actualColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymatChatView.ColorPair>.NativeClassPtr, "actualColor");
		}

		// Token: 0x06001C9E RID: 7326 RVA: 0x0001068C File Offset: 0x0000E88C
		public global::Il2CppSystem.Object BoxIl2CppObject()
		{
			return new global::Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WormPlaymatChatView.ColorPair>.NativeClassPtr, ref this));
		}

		// Token: 0x04001084 RID: 4228
		private static readonly IntPtr NativeFieldInfoPtr_PieceColor;

		// Token: 0x04001085 RID: 4229
		private static readonly IntPtr NativeFieldInfoPtr_actualColor;

		// Token: 0x04001086 RID: 4230
		[FieldOffset(0)]
		public PieceColor PieceColor;

		// Token: 0x04001087 RID: 4231
		[FieldOffset(4)]
		public Color actualColor;
	}

	// Token: 0x020002BF RID: 703
	[ObfuscatedName("WormPlaymatChatView+<>c__DisplayClass3_0")]
	public sealed class __c__DisplayClass3_0 : global::Il2CppSystem.Object
	{
		// Token: 0x06001C9F RID: 7327 RVA: 0x0007002C File Offset: 0x0006E22C
		// Note: this type is marked as 'beforefieldinit'.
		static __c__DisplayClass3_0()
		{
			Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<WormPlaymatChatView>.NativeClassPtr, "<>c__DisplayClass3_0");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr);
			WormPlaymatChatView.__c__DisplayClass3_0.NativeFieldInfoPtr_color = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr, "color");
			WormPlaymatChatView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr, 100663525);
			WormPlaymatChatView.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColor_b__0_Internal_Boolean_ColorPair_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr, 100663526);
		}

		// Token: 0x06001CA0 RID: 7328 RVA: 0x00070094 File Offset: 0x0006E294
		[CallerCount(2676)]
		[CachedScanResults(RefRangeStart = 341, RefRangeEnd = 3017, XrefRangeStart = 341, XrefRangeEnd = 3017, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __c__DisplayClass3_0()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WormPlaymatChatView.__c__DisplayClass3_0>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymatChatView.__c__DisplayClass3_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001CA1 RID: 7329 RVA: 0x000700D0 File Offset: 0x0006E2D0
		[CallerCount(0)]
		public unsafe bool _GetColor_b__0(WormPlaymatChatView.ColorPair pair)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pair;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WormPlaymatChatView.__c__DisplayClass3_0.NativeMethodInfoPtr__GetColor_b__0_Internal_Boolean_ColorPair_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001CA2 RID: 7330 RVA: 0x0001069E File Offset: 0x0000E89E
		public __c__DisplayClass3_0(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001CA3 RID: 7331 RVA: 0x0007011C File Offset: 0x0006E31C
		// (set) Token: 0x06001CA4 RID: 7332 RVA: 0x000106A7 File Offset: 0x0000E8A7
		public unsafe PieceColor color
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.__c__DisplayClass3_0.NativeFieldInfoPtr_color);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WormPlaymatChatView.__c__DisplayClass3_0.NativeFieldInfoPtr_color)) = value;
			}
		}

		// Token: 0x04001088 RID: 4232
		private static readonly IntPtr NativeFieldInfoPtr_color;

		// Token: 0x04001089 RID: 4233
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0400108A RID: 4234
		private static readonly IntPtr NativeMethodInfoPtr__GetColor_b__0_Internal_Boolean_ColorPair_0;
	}
}
