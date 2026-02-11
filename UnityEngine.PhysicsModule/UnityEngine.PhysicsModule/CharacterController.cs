using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x0200000C RID: 12
	public class CharacterController : Collider
	{
		// Token: 0x0600023F RID: 575 RVA: 0x000092D0 File Offset: 0x000074D0
		// Note: this type is marked as 'beforefieldinit'.
		static CharacterController()
		{
			Il2CppClassPointerStore<CharacterController>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.PhysicsModule.dll", "UnityEngine", "CharacterController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterController>.NativeClassPtr);
			CharacterController.get_isGroundedDelegateField = IL2CPP.ResolveICall<CharacterController.get_isGroundedDelegate>("UnityEngine.CharacterController::get_isGrounded");
			CharacterController.get_collisionFlagsDelegateField = IL2CPP.ResolveICall<CharacterController.get_collisionFlagsDelegate>("UnityEngine.CharacterController::get_collisionFlags");
			CharacterController.get_radiusDelegateField = IL2CPP.ResolveICall<CharacterController.get_radiusDelegate>("UnityEngine.CharacterController::get_radius");
			CharacterController.set_radiusDelegateField = IL2CPP.ResolveICall<CharacterController.set_radiusDelegate>("UnityEngine.CharacterController::set_radius");
			CharacterController.get_heightDelegateField = IL2CPP.ResolveICall<CharacterController.get_heightDelegate>("UnityEngine.CharacterController::get_height");
			CharacterController.set_heightDelegateField = IL2CPP.ResolveICall<CharacterController.set_heightDelegate>("UnityEngine.CharacterController::set_height");
			CharacterController.get_slopeLimitDelegateField = IL2CPP.ResolveICall<CharacterController.get_slopeLimitDelegate>("UnityEngine.CharacterController::get_slopeLimit");
			CharacterController.set_slopeLimitDelegateField = IL2CPP.ResolveICall<CharacterController.set_slopeLimitDelegate>("UnityEngine.CharacterController::set_slopeLimit");
			CharacterController.get_stepOffsetDelegateField = IL2CPP.ResolveICall<CharacterController.get_stepOffsetDelegate>("UnityEngine.CharacterController::get_stepOffset");
			CharacterController.set_stepOffsetDelegateField = IL2CPP.ResolveICall<CharacterController.set_stepOffsetDelegate>("UnityEngine.CharacterController::set_stepOffset");
			CharacterController.get_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.get_skinWidthDelegate>("UnityEngine.CharacterController::get_skinWidth");
			CharacterController.set_skinWidthDelegateField = IL2CPP.ResolveICall<CharacterController.set_skinWidthDelegate>("UnityEngine.CharacterController::set_skinWidth");
			CharacterController.get_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.get_minMoveDistanceDelegate>("UnityEngine.CharacterController::get_minMoveDistance");
			CharacterController.set_minMoveDistanceDelegateField = IL2CPP.ResolveICall<CharacterController.set_minMoveDistanceDelegate>("UnityEngine.CharacterController::set_minMoveDistance");
			CharacterController.get_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.get_detectCollisionsDelegate>("UnityEngine.CharacterController::get_detectCollisions");
			CharacterController.set_detectCollisionsDelegateField = IL2CPP.ResolveICall<CharacterController.set_detectCollisionsDelegate>("UnityEngine.CharacterController::set_detectCollisions");
			CharacterController.get_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.get_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::get_enableOverlapRecovery");
			CharacterController.set_enableOverlapRecoveryDelegateField = IL2CPP.ResolveICall<CharacterController.set_enableOverlapRecoveryDelegate>("UnityEngine.CharacterController::set_enableOverlapRecovery");
			CharacterController.SimpleMove_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.SimpleMove_InjectedDelegate>("UnityEngine.CharacterController::SimpleMove_Injected");
			CharacterController.Move_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.Move_InjectedDelegate>("UnityEngine.CharacterController::Move_Injected");
			CharacterController.get_velocity_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.get_velocity_InjectedDelegate>("UnityEngine.CharacterController::get_velocity_Injected");
			CharacterController.get_center_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.get_center_InjectedDelegate>("UnityEngine.CharacterController::get_center_Injected");
			CharacterController.set_center_InjectedDelegateField = IL2CPP.ResolveICall<CharacterController.set_center_InjectedDelegate>("UnityEngine.CharacterController::set_center_Injected");
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0000317D File Offset: 0x0000137D
		public CharacterController(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00003186 File Offset: 0x00001386
		public bool SimpleMove(Vector3 speed)
		{
			return this.SimpleMove_Injected(ref speed);
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00003190 File Offset: 0x00001390
		public CollisionFlags Move(Vector3 motion)
		{
			return this.Move_Injected(ref motion);
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000243 RID: 579 RVA: 0x0000945C File Offset: 0x0000765C
		public Vector3 velocity
		{
			get
			{
				Vector3 vector;
				this.get_velocity_Injected(out vector);
				return vector;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0000319A File Offset: 0x0000139A
		public bool isGrounded
		{
			get
			{
				return CharacterController.get_isGroundedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000245 RID: 581 RVA: 0x000031AC File Offset: 0x000013AC
		public CollisionFlags collisionFlags
		{
			get
			{
				return CharacterController.get_collisionFlagsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000246 RID: 582 RVA: 0x000031BE File Offset: 0x000013BE
		// (set) Token: 0x06000247 RID: 583 RVA: 0x000031D0 File Offset: 0x000013D0
		public float radius
		{
			get
			{
				return CharacterController.get_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_radiusDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000248 RID: 584 RVA: 0x000031E3 File Offset: 0x000013E3
		// (set) Token: 0x06000249 RID: 585 RVA: 0x000031F5 File Offset: 0x000013F5
		public float height
		{
			get
			{
				return CharacterController.get_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_heightDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600024A RID: 586 RVA: 0x00009474 File Offset: 0x00007674
		// (set) Token: 0x0600024B RID: 587 RVA: 0x00003208 File Offset: 0x00001408
		public Vector3 center
		{
			get
			{
				Vector3 vector;
				this.get_center_Injected(out vector);
				return vector;
			}
			set
			{
				this.set_center_Injected(ref value);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00003212 File Offset: 0x00001412
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00003224 File Offset: 0x00001424
		public float slopeLimit
		{
			get
			{
				return CharacterController.get_slopeLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_slopeLimitDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00003237 File Offset: 0x00001437
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00003249 File Offset: 0x00001449
		public float stepOffset
		{
			get
			{
				return CharacterController.get_stepOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_stepOffsetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000250 RID: 592 RVA: 0x0000325C File Offset: 0x0000145C
		// (set) Token: 0x06000251 RID: 593 RVA: 0x0000326E File Offset: 0x0000146E
		public float skinWidth
		{
			get
			{
				return CharacterController.get_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_skinWidthDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000252 RID: 594 RVA: 0x00003281 File Offset: 0x00001481
		// (set) Token: 0x06000253 RID: 595 RVA: 0x00003293 File Offset: 0x00001493
		public float minMoveDistance
		{
			get
			{
				return CharacterController.get_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_minMoveDistanceDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000032A6 File Offset: 0x000014A6
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000032B8 File Offset: 0x000014B8
		public bool detectCollisions
		{
			get
			{
				return CharacterController.get_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_detectCollisionsDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000256 RID: 598 RVA: 0x000032CB File Offset: 0x000014CB
		// (set) Token: 0x06000257 RID: 599 RVA: 0x000032DD File Offset: 0x000014DD
		public bool enableOverlapRecovery
		{
			get
			{
				return CharacterController.get_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			}
			set
			{
				CharacterController.set_enableOverlapRecoveryDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), value);
			}
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000032F0 File Offset: 0x000014F0
		public bool SimpleMove_Injected(ref Vector3 speed)
		{
			return CharacterController.SimpleMove_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref speed);
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00003303 File Offset: 0x00001503
		public CollisionFlags Move_Injected(ref Vector3 motion)
		{
			return CharacterController.Move_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref motion);
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003316 File Offset: 0x00001516
		public void get_velocity_Injected(out Vector3 ret)
		{
			CharacterController.get_velocity_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003329 File Offset: 0x00001529
		public void get_center_Injected(out Vector3 ret)
		{
			CharacterController.get_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), out ret);
		}

		// Token: 0x0600025C RID: 604 RVA: 0x0000333C File Offset: 0x0000153C
		public void set_center_Injected(ref Vector3 value)
		{
			CharacterController.set_center_InjectedDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), ref value);
		}

		// Token: 0x04000139 RID: 313
		private static readonly CharacterController.get_isGroundedDelegate get_isGroundedDelegateField;

		// Token: 0x0400013A RID: 314
		private static readonly CharacterController.get_collisionFlagsDelegate get_collisionFlagsDelegateField;

		// Token: 0x0400013B RID: 315
		private static readonly CharacterController.get_radiusDelegate get_radiusDelegateField;

		// Token: 0x0400013C RID: 316
		private static readonly CharacterController.set_radiusDelegate set_radiusDelegateField;

		// Token: 0x0400013D RID: 317
		private static readonly CharacterController.get_heightDelegate get_heightDelegateField;

		// Token: 0x0400013E RID: 318
		private static readonly CharacterController.set_heightDelegate set_heightDelegateField;

		// Token: 0x0400013F RID: 319
		private static readonly CharacterController.get_slopeLimitDelegate get_slopeLimitDelegateField;

		// Token: 0x04000140 RID: 320
		private static readonly CharacterController.set_slopeLimitDelegate set_slopeLimitDelegateField;

		// Token: 0x04000141 RID: 321
		private static readonly CharacterController.get_stepOffsetDelegate get_stepOffsetDelegateField;

		// Token: 0x04000142 RID: 322
		private static readonly CharacterController.set_stepOffsetDelegate set_stepOffsetDelegateField;

		// Token: 0x04000143 RID: 323
		private static readonly CharacterController.get_skinWidthDelegate get_skinWidthDelegateField;

		// Token: 0x04000144 RID: 324
		private static readonly CharacterController.set_skinWidthDelegate set_skinWidthDelegateField;

		// Token: 0x04000145 RID: 325
		private static readonly CharacterController.get_minMoveDistanceDelegate get_minMoveDistanceDelegateField;

		// Token: 0x04000146 RID: 326
		private static readonly CharacterController.set_minMoveDistanceDelegate set_minMoveDistanceDelegateField;

		// Token: 0x04000147 RID: 327
		private static readonly CharacterController.get_detectCollisionsDelegate get_detectCollisionsDelegateField;

		// Token: 0x04000148 RID: 328
		private static readonly CharacterController.set_detectCollisionsDelegate set_detectCollisionsDelegateField;

		// Token: 0x04000149 RID: 329
		private static readonly CharacterController.get_enableOverlapRecoveryDelegate get_enableOverlapRecoveryDelegateField;

		// Token: 0x0400014A RID: 330
		private static readonly CharacterController.set_enableOverlapRecoveryDelegate set_enableOverlapRecoveryDelegateField;

		// Token: 0x0400014B RID: 331
		private static readonly CharacterController.SimpleMove_InjectedDelegate SimpleMove_InjectedDelegateField;

		// Token: 0x0400014C RID: 332
		private static readonly CharacterController.Move_InjectedDelegate Move_InjectedDelegateField;

		// Token: 0x0400014D RID: 333
		private static readonly CharacterController.get_velocity_InjectedDelegate get_velocity_InjectedDelegateField;

		// Token: 0x0400014E RID: 334
		private static readonly CharacterController.get_center_InjectedDelegate get_center_InjectedDelegateField;

		// Token: 0x0400014F RID: 335
		private static readonly CharacterController.set_center_InjectedDelegate set_center_InjectedDelegateField;

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000576 RID: 1398
		private delegate bool get_isGroundedDelegate(IntPtr @this);

		// Token: 0x020000D0 RID: 208
		// (Invoke) Token: 0x06000578 RID: 1400
		private delegate CollisionFlags get_collisionFlagsDelegate(IntPtr @this);

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600057A RID: 1402
		private delegate float get_radiusDelegate(IntPtr @this);

		// Token: 0x020000D2 RID: 210
		// (Invoke) Token: 0x0600057C RID: 1404
		private delegate void set_radiusDelegate(IntPtr @this, float value);

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x0600057E RID: 1406
		private delegate float get_heightDelegate(IntPtr @this);

		// Token: 0x020000D4 RID: 212
		// (Invoke) Token: 0x06000580 RID: 1408
		private delegate void set_heightDelegate(IntPtr @this, float value);

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x06000582 RID: 1410
		private delegate float get_slopeLimitDelegate(IntPtr @this);

		// Token: 0x020000D6 RID: 214
		// (Invoke) Token: 0x06000584 RID: 1412
		private delegate void set_slopeLimitDelegate(IntPtr @this, float value);

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x06000586 RID: 1414
		private delegate float get_stepOffsetDelegate(IntPtr @this);

		// Token: 0x020000D8 RID: 216
		// (Invoke) Token: 0x06000588 RID: 1416
		private delegate void set_stepOffsetDelegate(IntPtr @this, float value);

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x0600058A RID: 1418
		private delegate float get_skinWidthDelegate(IntPtr @this);

		// Token: 0x020000DA RID: 218
		// (Invoke) Token: 0x0600058C RID: 1420
		private delegate void set_skinWidthDelegate(IntPtr @this, float value);

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x0600058E RID: 1422
		private delegate float get_minMoveDistanceDelegate(IntPtr @this);

		// Token: 0x020000DC RID: 220
		// (Invoke) Token: 0x06000590 RID: 1424
		private delegate void set_minMoveDistanceDelegate(IntPtr @this, float value);

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x06000592 RID: 1426
		private delegate bool get_detectCollisionsDelegate(IntPtr @this);

		// Token: 0x020000DE RID: 222
		// (Invoke) Token: 0x06000594 RID: 1428
		private delegate void set_detectCollisionsDelegate(IntPtr @this, bool value);

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x06000596 RID: 1430
		private delegate bool get_enableOverlapRecoveryDelegate(IntPtr @this);

		// Token: 0x020000E0 RID: 224
		// (Invoke) Token: 0x06000598 RID: 1432
		private delegate void set_enableOverlapRecoveryDelegate(IntPtr @this, bool value);

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x0600059A RID: 1434
		private delegate bool SimpleMove_InjectedDelegate(IntPtr @this, IntPtr speed);

		// Token: 0x020000E2 RID: 226
		// (Invoke) Token: 0x0600059C RID: 1436
		private delegate CollisionFlags Move_InjectedDelegate(IntPtr @this, IntPtr motion);

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x0600059E RID: 1438
		private delegate void get_velocity_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000E4 RID: 228
		// (Invoke) Token: 0x060005A0 RID: 1440
		private delegate void get_center_InjectedDelegate(IntPtr @this, [Out] IntPtr ret);

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x060005A2 RID: 1442
		private delegate void set_center_InjectedDelegate(IntPtr @this, IntPtr value);
	}
}
