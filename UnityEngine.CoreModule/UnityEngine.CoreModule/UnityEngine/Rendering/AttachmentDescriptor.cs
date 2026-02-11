using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
	// Token: 0x02000229 RID: 553
	[StructLayout(2)]
	public struct AttachmentDescriptor
	{
		// Token: 0x060024FD RID: 9469 RVA: 0x0009E224 File Offset: 0x0009C424
		// Note: this type is marked as 'beforefieldinit'.
		static AttachmentDescriptor()
		{
			Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Rendering", "AttachmentDescriptor");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr);
			AttachmentDescriptor.NativeFieldInfoPtr_m_LoadAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadAction");
			AttachmentDescriptor.NativeFieldInfoPtr_m_StoreAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_StoreAction");
			AttachmentDescriptor.NativeFieldInfoPtr_m_Format = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_Format");
			AttachmentDescriptor.NativeFieldInfoPtr_m_LoadStoreTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_LoadStoreTarget");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ResolveTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ResolveTarget");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearColor");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearDepth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearDepth");
			AttachmentDescriptor.NativeFieldInfoPtr_m_ClearStencil = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, "m_ClearStencil");
			AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668072);
			AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668073);
			AttachmentDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668074);
			AttachmentDescriptor.NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668075);
			AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668076);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668077);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668078);
			AttachmentDescriptor.NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668079);
			AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668080);
			AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668081);
			AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668082);
			AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668083);
			AttachmentDescriptor.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, 100668084);
		}

		// Token: 0x17000739 RID: 1849
		// (get) Token: 0x0600250C RID: 9484 RVA: 0x0009E6FC File Offset: 0x0009C8FC
		// (set) Token: 0x060024FE RID: 9470 RVA: 0x0009E3F8 File Offset: 0x0009C5F8
		public unsafe RenderBufferLoadAction loadAction
		{
			get
			{
				return this.m_LoadAction;
			}
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 320163, RefRangeEnd = 320170, XrefRangeStart = 320163, XrefRangeEnd = 320170, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700073A RID: 1850
		// (get) Token: 0x0600250D RID: 9485 RVA: 0x0009E714 File Offset: 0x0009C914
		// (set) Token: 0x060024FF RID: 9471 RVA: 0x0009E42C File Offset: 0x0009C62C
		public unsafe RenderBufferStoreAction storeAction
		{
			get
			{
				return this.m_StoreAction;
			}
			[CallerCount(6)]
			[CachedScanResults(RefRangeStart = 320170, RefRangeEnd = 320176, XrefRangeStart = 320170, XrefRangeEnd = 320176, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x1700073B RID: 1851
		// (get) Token: 0x06002500 RID: 9472 RVA: 0x0009E460 File Offset: 0x0009C660
		// (set) Token: 0x0600250E RID: 9486 RVA: 0x0000EAE6 File Offset: 0x0000CCE6
		public unsafe UnityEngine.Experimental.Rendering.GraphicsFormat graphicsFormat
		{
			[CallerCount(27)]
			[CachedScanResults(RefRangeStart = 335516, RefRangeEnd = 335543, XrefRangeStart = 335516, XrefRangeEnd = 335543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			set
			{
				this.m_Format = value;
			}
		}

		// Token: 0x1700073C RID: 1852
		// (get) Token: 0x06002501 RID: 9473 RVA: 0x0009E490 File Offset: 0x0009C690
		// (set) Token: 0x06002502 RID: 9474 RVA: 0x0009E4C0 File Offset: 0x0009C6C0
		public unsafe RenderTargetIdentifier loadStoreTarget
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 683275, RefRangeEnd = 683279, XrefRangeStart = 683275, XrefRangeEnd = 683275, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 683279, RefRangeEnd = 683281, XrefRangeStart = 683279, XrefRangeEnd = 683279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x06002503 RID: 9475 RVA: 0x0009E4F4 File Offset: 0x0009C6F4
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 683281, RefRangeEnd = 683285, XrefRangeStart = 683281, XrefRangeEnd = 683281, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureTarget(RenderTargetIdentifier target, bool loadExistingContents, bool storeResults)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref loadExistingContents;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref storeResults;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x0009E544 File Offset: 0x0009C744
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683285, RefRangeEnd = 683287, XrefRangeStart = 683285, XrefRangeEnd = 683285, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureResolveTarget(RenderTargetIdentifier target)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref target;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x0009E578 File Offset: 0x0009C778
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 683287, RefRangeEnd = 683292, XrefRangeStart = 683287, XrefRangeEnd = 683287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ConfigureClear(Color clearColor, float clearDepth = 1f, uint clearStencil = 0U)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref clearColor;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearDepth;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref clearStencil;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x0009E5C8 File Offset: 0x0009C7C8
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 683292, RefRangeEnd = 683297, XrefRangeStart = 683292, XrefRangeEnd = 683292, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AttachmentDescriptor(UnityEngine.Experimental.Rendering.GraphicsFormat format)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref format;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x0009E5FC File Offset: 0x0009C7FC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 683305, RefRangeEnd = 683307, XrefRangeStart = 683297, XrefRangeEnd = 683305, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(AttachmentDescriptor other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x0009E63C File Offset: 0x0009C83C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683307, XrefRangeEnd = 683311, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x0009E680 File Offset: 0x0009C880
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 683311, XrefRangeEnd = 683322, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x0009E6B0 File Offset: 0x0009C8B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 683323, RefRangeEnd = 683324, XrefRangeStart = 683322, XrefRangeEnd = 683323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator !=(AttachmentDescriptor left, AttachmentDescriptor right)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref left;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref right;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AttachmentDescriptor.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AttachmentDescriptor>.NativeClassPtr, ref this));
		}

		// Token: 0x1700073D RID: 1853
		// (get) Token: 0x0600250F RID: 9487 RVA: 0x0009E72C File Offset: 0x0009C92C
		// (set) Token: 0x06002510 RID: 9488 RVA: 0x0000EAF0 File Offset: 0x0000CCF0
		public RenderTextureFormat format
		{
			get
			{
				bool flag = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.IsDepthStencilFormat(this.m_Format) && this.m_Format != UnityEngine.Experimental.Rendering.GraphicsFormat.ShadowAuto;
				RenderTextureFormat renderTextureFormat;
				if (flag)
				{
					renderTextureFormat = RenderTextureFormat.Depth;
				}
				else
				{
					renderTextureFormat = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetRenderTextureFormat(this.m_Format);
				}
				return renderTextureFormat;
			}
			set
			{
				this.m_Format = UnityEngine.Experimental.Rendering.GraphicsFormatUtility.GetGraphicsFormat(value, RenderTextureReadWrite.Default);
			}
		}

		// Token: 0x1700073E RID: 1854
		// (get) Token: 0x06002511 RID: 9489 RVA: 0x0009E774 File Offset: 0x0009C974
		// (set) Token: 0x06002512 RID: 9490 RVA: 0x0000EB00 File Offset: 0x0000CD00
		public RenderTargetIdentifier resolveTarget
		{
			get
			{
				return this.m_ResolveTarget;
			}
			set
			{
				this.m_ResolveTarget = value;
			}
		}

		// Token: 0x1700073F RID: 1855
		// (get) Token: 0x06002513 RID: 9491 RVA: 0x0009E78C File Offset: 0x0009C98C
		// (set) Token: 0x06002514 RID: 9492 RVA: 0x0000EB0A File Offset: 0x0000CD0A
		public Color clearColor
		{
			get
			{
				return this.m_ClearColor;
			}
			set
			{
				this.m_ClearColor = value;
			}
		}

		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x06002515 RID: 9493 RVA: 0x0009E7A4 File Offset: 0x0009C9A4
		// (set) Token: 0x06002516 RID: 9494 RVA: 0x0000EB14 File Offset: 0x0000CD14
		public float clearDepth
		{
			get
			{
				return this.m_ClearDepth;
			}
			set
			{
				this.m_ClearDepth = value;
			}
		}

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x0009E7BC File Offset: 0x0009C9BC
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x0000EB1E File Offset: 0x0000CD1E
		public uint clearStencil
		{
			get
			{
				return this.m_ClearStencil;
			}
			set
			{
				this.m_ClearStencil = value;
			}
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x0009E7D4 File Offset: 0x0009C9D4
		public static bool operator ==(AttachmentDescriptor left, AttachmentDescriptor right)
		{
			return left.Equals(right);
		}

		// Token: 0x040020A0 RID: 8352
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadAction;

		// Token: 0x040020A1 RID: 8353
		private static readonly IntPtr NativeFieldInfoPtr_m_StoreAction;

		// Token: 0x040020A2 RID: 8354
		private static readonly IntPtr NativeFieldInfoPtr_m_Format;

		// Token: 0x040020A3 RID: 8355
		private static readonly IntPtr NativeFieldInfoPtr_m_LoadStoreTarget;

		// Token: 0x040020A4 RID: 8356
		private static readonly IntPtr NativeFieldInfoPtr_m_ResolveTarget;

		// Token: 0x040020A5 RID: 8357
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearColor;

		// Token: 0x040020A6 RID: 8358
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearDepth;

		// Token: 0x040020A7 RID: 8359
		private static readonly IntPtr NativeFieldInfoPtr_m_ClearStencil;

		// Token: 0x040020A8 RID: 8360
		private static readonly IntPtr NativeMethodInfoPtr_set_loadAction_Public_set_Void_RenderBufferLoadAction_0;

		// Token: 0x040020A9 RID: 8361
		private static readonly IntPtr NativeMethodInfoPtr_set_storeAction_Public_set_Void_RenderBufferStoreAction_0;

		// Token: 0x040020AA RID: 8362
		private static readonly IntPtr NativeMethodInfoPtr_get_graphicsFormat_Public_get_GraphicsFormat_0;

		// Token: 0x040020AB RID: 8363
		private static readonly IntPtr NativeMethodInfoPtr_get_loadStoreTarget_Public_get_RenderTargetIdentifier_0;

		// Token: 0x040020AC RID: 8364
		private static readonly IntPtr NativeMethodInfoPtr_set_loadStoreTarget_Public_set_Void_RenderTargetIdentifier_0;

		// Token: 0x040020AD RID: 8365
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureTarget_Public_Void_RenderTargetIdentifier_Boolean_Boolean_0;

		// Token: 0x040020AE RID: 8366
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureResolveTarget_Public_Void_RenderTargetIdentifier_0;

		// Token: 0x040020AF RID: 8367
		private static readonly IntPtr NativeMethodInfoPtr_ConfigureClear_Public_Void_Color_Single_UInt32_0;

		// Token: 0x040020B0 RID: 8368
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_GraphicsFormat_0;

		// Token: 0x040020B1 RID: 8369
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AttachmentDescriptor_0;

		// Token: 0x040020B2 RID: 8370
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040020B3 RID: 8371
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040020B4 RID: 8372
		private static readonly IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AttachmentDescriptor_AttachmentDescriptor_0;

		// Token: 0x040020B5 RID: 8373
		[FieldOffset(0)]
		public RenderBufferLoadAction m_LoadAction;

		// Token: 0x040020B6 RID: 8374
		[FieldOffset(4)]
		public RenderBufferStoreAction m_StoreAction;

		// Token: 0x040020B7 RID: 8375
		[FieldOffset(8)]
		public UnityEngine.Experimental.Rendering.GraphicsFormat m_Format;

		// Token: 0x040020B8 RID: 8376
		[FieldOffset(16)]
		public RenderTargetIdentifier m_LoadStoreTarget;

		// Token: 0x040020B9 RID: 8377
		[FieldOffset(56)]
		public RenderTargetIdentifier m_ResolveTarget;

		// Token: 0x040020BA RID: 8378
		[FieldOffset(96)]
		public Color m_ClearColor;

		// Token: 0x040020BB RID: 8379
		[FieldOffset(112)]
		public float m_ClearDepth;

		// Token: 0x040020BC RID: 8380
		[FieldOffset(116)]
		public uint m_ClearStencil;
	}
}
